using System;
using System.Drawing;
using System.Data;
using System.Reflection;
using System.ComponentModel;
using System.Collections;

namespace Demo
{
	public class Company
	{
		private string companyname;
		public string CompanyName
		{
			get
			{
				return companyname;
			}
			set
			{
				companyname = value;
			}
		}


		public Company(string companyname)
		{
			this.companyname = companyname;
		}
	}


	public class Department
	{
		private Company company;
		public Company Company
		{
			get
			{
				return company;
			}
			set
			{
				company = value;
			}
		}

	
		private string departmentName;		
		public string DepartmentName
		{
			get
			{
				return departmentName;
			}
			set
			{
				departmentName = value;
			}
		}


		public Department(Company company, string departmentName)
		{
			this.company = company;
			this.departmentName = departmentName;
		}
	}


	public class Phone
	{
		private string number;
		public string Number
		{
			get
			{
				return number;
			}
			set
			{
				number = value;
			}
		}


		public Phone(string number)
		{
			this.number = number;
		}
	}


	public class Employee
	{
		private Department department;
		public Department Department
		{
			get
			{
				return department;
			}
			set
			{
				department = value;
			}
		}


		private string employeeName;
		public string EmployeeName
		{
			get
			{
				return employeeName;
			}
			set
			{
				employeeName = value;
			}
		}


		private PhoneCollection phones = new PhoneCollection();
		public PhoneCollection Phones
		{
			get
			{
				return phones;
			}
			set
			{
				phones = value;
			}
		}


		private string email;
		public string Email
		{
			get
			{
				return email;
			}
			set
			{
				email = value;
			}
		}

		public Employee(Department department, string employeeName, string email)
		{
			this.department = department;
			this.employeeName = employeeName;
			this.email = email;
		}
	}


	public class EmployeeCollection : CollectionBase, ITypedList
	{
		PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
		{
            PropertyInfo[] props = typeof(Employee).GetProperties();
			PropertyDescriptor[] descs = new PropertyDescriptor[props.Length];

			int index = 0;
			foreach (PropertyInfo prop in props)
			{
				descs[index] = new EmployeePropertyDescriptor(prop.Name);
				index++;
			}
			return new PropertyDescriptorCollection(descs);
		}

		string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
		{
            return "EmployeesCollection";
		}


		public void Add(Employee employee)
		{
			List.Add(employee);
		}

		public void AddRange(Employee[] employees)
		{
			base.InnerList.AddRange(employees);
		}

		public bool Contains(Employee employee)
		{
			return List.Contains(employee);
		}
		
		public int IndexOf(Employee employee)
		{
			return List.IndexOf(employee);
		}

		public void Insert(int index, Employee employee)
		{
			List.Insert(index, employee);
		}

		public void Remove(Employee employee)
		{
			List.Remove(employee);
		}


	}


	public class PhoneCollection : CollectionBase
	{
		public void Add(Phone phone)
		{
			List.Add(phone);
		}

		public void AddRange(Phone[] phone)
		{
			base.InnerList.AddRange(phone);
		}

		public bool Contains(Phone phone)
		{
			return List.Contains(phone);
		}
		
		public int IndexOf(Phone phone)
		{
			return List.IndexOf(phone);
		}

		public void Insert(int index, Phone phone)
		{
			List.Insert(index, phone);
		}

		public void Remove(Phone phone)
		{
			List.Remove(phone);
		}
	}


	public class EmployeePropertyDescriptor : PropertyDescriptor
	{
		public EmployeePropertyDescriptor(string propertyName) : base(propertyName, null)
		{
			this.propertyName = propertyName;
		}

		private string propertyName;

		public override bool CanResetValue(object component)
		{
			return false;
		}

		public override Type ComponentType
		{
			get
			{
				return typeof(Employee);
			}
		}

		public override object GetValue(object component)
		{
			return component.GetType().GetProperty(propertyName).GetValue(component, null);
		}

		public override void SetValue(object component, object value)
		{
			component.GetType().GetProperty(propertyName).SetValue(component, value, null);
		}

		public override bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		public override Type PropertyType
		{
			get
			{
				return typeof(Employee).GetProperty(propertyName).PropertyType;
			}
		}

		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}

		public override void ResetValue(object component)
		{

		}

	}


	public sealed class CreateBusinessObjects
	{
		public static EmployeeCollection GetEmployees()
		{
			EmployeeCollection employees = new EmployeeCollection();
			Company company1 = new Company("Company1");
            Company company2 = new Company("Company2");
			
			Department salesDepartment = new Department(company1, "Sales Department");
            Department storeDepartment = new Department(company2, "Store Department");
			
			Employee emp = new Employee(salesDepartment, "Nicholas", "Nicholas@company1.com");
			emp.Phones.Add(new Phone("(206) 555-9857"));
			emp.Phones.Add(new Phone("(206) 555-6546"));
			emp.Phones.Add(new Phone("(206) 555-7651"));
			employees.Add(emp);

			emp = new Employee(salesDepartment, "Margaret", "Margaret@company1.com");
			emp.Phones.Add(new Phone("(206) 555-4546"));
			emp.Phones.Add(new Phone("(206) 555-0110"));
			employees.Add(emp);

			emp = new Employee(salesDepartment, "Janet", "Janet@company1.com");
			emp.Phones.Add(new Phone("(206) 555-5462"));
			emp.Phones.Add(new Phone("(206) 555-8400"));
			emp.Phones.Add(new Phone("(206) 555-9842"));
			employees.Add(emp);

			emp = new Employee(salesDepartment, "Laura", "Laura@company1.com");
			emp.Phones.Add(new Phone("(206) 555-0022"));
			employees.Add(emp);

            emp = new Employee(storeDepartment, "Mark", "Mark@company2.com");
			emp.Phones.Add(new Phone("(206) 555-9980"));
			emp.Phones.Add(new Phone("(206) 555-5567"));
			employees.Add(emp);

            emp = new Employee(storeDepartment, "Michael", "Michael@company2.com");
			emp.Phones.Add(new Phone("(206) 555-5642"));
			employees.Add(emp);

            emp = new Employee(storeDepartment, "Thomas", "Thomas@company2.com");
			emp.Phones.Add(new Phone("(206) 555-8949"));
			employees.Add(emp);


			return employees;
		}

		public static Employee GetEmployee()
		{
			Company company = new Company("Company1");
			Department salesDepartment = new Department(company, "Sales Department");
			Employee employee = new Employee(salesDepartment, "Nicholas", "Nicholas@company1.com");
			return employee;
		}
	}

}