using System;
using System.Data;
using System.Reflection;
using System.ComponentModel;
using System.Collections;

namespace BusinessObjects
{
	public class EmployeeITypedList
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


		private PhoneITypedListCollection phones = new PhoneITypedListCollection();
		public PhoneITypedListCollection Phones
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


		public EmployeeITypedList(Department department, string employeeName, string email)
		{
			this.department = department;
			this.employeeName = employeeName;
			this.email = email;
		}
	}


	public class EmployeeITypedListCollection : CollectionBase, ITypedList
	{
		PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
		{
            PropertyInfo[] props = typeof(EmployeeITypedList).GetProperties();
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
            return "EmployeesITypedList";
		}


		public void Add(EmployeeITypedList employee)
		{
			List.Add(employee);
		}

		public void AddRange(EmployeeITypedList[] employees)
		{
			base.InnerList.AddRange(employees);
		}

		public bool Contains(EmployeeITypedList employee)
		{
			return List.Contains(employee);
		}
		
		public int IndexOf(EmployeeITypedList employee)
		{
			return List.IndexOf(employee);
		}

		public void Insert(int index, EmployeeITypedList employee)
		{
			List.Insert(index, employee);
		}

		public void Remove(EmployeeITypedList employee)
		{
			List.Remove(employee);
		}
	}


	public class PhoneITypedListCollection : CollectionBase, ITypedList
	{
		PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			PropertyInfo[] props = typeof(Phone).GetProperties();
			PropertyDescriptor[] descs = new PropertyDescriptor[props.Length];

			int index = 0;
			foreach (PropertyInfo prop in props)
			{
				descs[index] = new PhonePropertyDescriptor(prop.Name);
				index++;
			}
			return new PropertyDescriptorCollection(descs);
		}

		string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
		{
			return "PhonesITypedList";
		}

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
				return typeof(EmployeeITypedList);
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
				return typeof(EmployeeITypedList).GetProperty(propertyName).PropertyType;
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


	public class PhonePropertyDescriptor : PropertyDescriptor
	{
		public PhonePropertyDescriptor(string propertyName) : base(propertyName, null)
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
				return typeof(Phone);
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
				return typeof(Phone).GetProperty(propertyName).PropertyType;
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


	public sealed class CreateBusinessObjectsITypedList
	{
		public static EmployeeITypedListCollection GetEmployees()
		{
			EmployeeITypedListCollection employees = new EmployeeITypedListCollection();
			Company company = new Company("Company1");
			Department storeDepartment = new Department(company, "Store Department");
			Department salesDepartment = new Department(company, "Sales Department");
			
			EmployeeITypedList emp = new EmployeeITypedList(storeDepartment, "Nicholas", "Nicholas@company1.com");
			emp.Phones.Add(new Phone("(206) 555-9857"));
			emp.Phones.Add(new Phone("(206) 555-6546"));
			emp.Phones.Add(new Phone("(206) 555-7651"));
			employees.Add(emp);

			emp = new EmployeeITypedList(storeDepartment, "Margaret", "Margaret@company1.com");
			emp.Phones.Add(new Phone("(206) 555-4546"));
			emp.Phones.Add(new Phone("(206) 555-0110"));
			employees.Add(emp);

			emp = new EmployeeITypedList(storeDepartment, "Janet", "Janet@company1.com");
			emp.Phones.Add(new Phone("(206) 555-5462"));
			emp.Phones.Add(new Phone("(206) 555-8400"));
			emp.Phones.Add(new Phone("(206) 555-9842"));
			employees.Add(emp);

			emp = new EmployeeITypedList(salesDepartment, "Laura", "Laura@company1.com");
			emp.Phones.Add(new Phone("(206) 555-0022"));
			employees.Add(emp);
			
			emp = new EmployeeITypedList(salesDepartment, "Mark", "Mark@company1.com");
			emp.Phones.Add(new Phone("(206) 555-9980"));
			emp.Phones.Add(new Phone("(206) 555-5567"));
			employees.Add(emp);
			
			emp = new EmployeeITypedList(salesDepartment, "Michael", "Michael@company1.com");
			emp.Phones.Add(new Phone("(206) 555-5642"));
			employees.Add(emp);
			
			emp = new EmployeeITypedList(salesDepartment, "Thomas", "Thomas@company1.com");
			emp.Phones.Add(new Phone("(206) 555-8949"));
			employees.Add(emp);

			return employees;
		}
	}
}