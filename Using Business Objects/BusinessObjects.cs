using System;
using System.Data;
using System.Reflection;
using System.ComponentModel;
using System.Collections;

namespace BusinessObjects
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

}