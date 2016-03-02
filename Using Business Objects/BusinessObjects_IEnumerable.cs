using System;
using System.Data;
using System.Reflection;
using System.ComponentModel;
using System.Collections;

namespace BusinessObjects
{
	public class EmployeeIEnumerable
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


		private PhoneIEnumerableCollection phones = new PhoneIEnumerableCollection();
		public PhoneIEnumerableCollection Phones
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


		public EmployeeIEnumerable(Department department, string employeeName, string email)
		{
			this.department = department;
			this.employeeName = employeeName;
			this.email = email;
		}
	}


	public class EmployeeIEnumerableCollection : CollectionBase
	{
		public void Add(EmployeeIEnumerable employee)
		{
			List.Add(employee);
		}

		public void AddRange(EmployeeIEnumerable[] employees)
		{
			base.InnerList.AddRange(employees);
		}

		public bool Contains(EmployeeIEnumerable employee)
		{
			return List.Contains(employee);
		}
		
		public int IndexOf(EmployeeIEnumerable employee)
		{
			return List.IndexOf(employee);
		}

		public void Insert(int index, EmployeeIEnumerable employee)
		{
			List.Insert(index, employee);
		}

		public void Remove(EmployeeIEnumerable employee)
		{
			List.Remove(employee);
		}


	}


	public class PhoneIEnumerableCollection : CollectionBase
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


	public sealed class CreateBusinessObjectsIEnumerable
	{
		public static EmployeeIEnumerableCollection GetEmployees()
		{
			EmployeeIEnumerableCollection employees = new EmployeeIEnumerableCollection();
			Company company = new Company("Company1");
			Department storeDepartment = new Department(company, "Store Department");
			Department salesDepartment = new Department(company, "Sales Department");
			
			EmployeeIEnumerable emp = new EmployeeIEnumerable(storeDepartment, "Nicholas", "Nicholas@company1.com");
			emp.Phones.Add(new Phone("(206) 555-9857"));
			emp.Phones.Add(new Phone("(206) 555-6546"));
			emp.Phones.Add(new Phone("(206) 555-7651"));
			employees.Add(emp);

			emp = new EmployeeIEnumerable(storeDepartment, "Margaret", "Margaret@company1.com");
			emp.Phones.Add(new Phone("(206) 555-4546"));
			emp.Phones.Add(new Phone("(206) 555-0110"));
			employees.Add(emp);

			emp = new EmployeeIEnumerable(storeDepartment, "Janet", "Janet@company1.com");
			emp.Phones.Add(new Phone("(206) 555-5462"));
			emp.Phones.Add(new Phone("(206) 555-8400"));
			emp.Phones.Add(new Phone("(206) 555-9842"));
			employees.Add(emp);

			emp = new EmployeeIEnumerable(salesDepartment, "Laura", "Laura@company1.com");
			emp.Phones.Add(new Phone("(206) 555-0022"));
			employees.Add(emp);
			
			emp = new EmployeeIEnumerable(salesDepartment, "Mark", "Mark@company1.com");
			emp.Phones.Add(new Phone("(206) 555-9980"));
			emp.Phones.Add(new Phone("(206) 555-5567"));
			employees.Add(emp);
			
			emp = new EmployeeIEnumerable(salesDepartment, "Michael", "Michael@company1.com");
			emp.Phones.Add(new Phone("(206) 555-5642"));
			employees.Add(emp);
			
			emp = new EmployeeIEnumerable(salesDepartment, "Thomas", "Thomas@company1.com");
			emp.Phones.Add(new Phone("(206) 555-8949"));
			employees.Add(emp);

			return employees;
		}

	}

}