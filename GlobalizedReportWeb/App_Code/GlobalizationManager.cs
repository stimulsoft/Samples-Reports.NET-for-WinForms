using System;
using System.Drawing;
using System.Reflection;
using System.Globalization;
using System.Resources;
using Stimulsoft.Report;

namespace GlobalizedReport
{
	/// <summary>
	/// Summary description for GlobalizationManager.
	/// </summary>
	public class GlobalizationManager : IStiGlobalizationManager, IStiGlobalizationManagerList
	{
		#region IStiGlobalizationManagerList
		public string[] GetTextGlobalizedNames()
		{
			return new string[]
				{
					"Company",
					"Address",
					"Phone",
					"Contact",
					"PageNofM",
					"ReportName"
				};
		}

		public string[] GetImageGlobalizedNames()
		{
			return new string[]
				{
					"Flag"
				};
		}
		#endregion

		#region IStiGlobalizationManager
		private CultureInfo culture;
		public CultureInfo Culture
		{ 
			get
			{
				return culture;
			}
			set
			{
				culture = value;
			}
		}

		public string GetString(string name)
		{
			return Resources.Resources.ResourceManager.GetString(name, Culture);
		}

		public object GetObject(string name)
		{
			return Resources.Resources.ResourceManager.GetObject(name, Culture);
		}
		#endregion

		public GlobalizationManager(CultureInfo culture) 
		{
			this.culture = culture;
		}
	}
}
