using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using Stimulsoft.Base;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Base.Serializing;
using Stimulsoft.Base.Services;
using Stimulsoft.Base.Design;
using Stimulsoft.Base.Localization;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Events;
using Stimulsoft.Report.Components.Design;
using Stimulsoft.Report.Design;


namespace CustomComponent
{
	public class MyCustomComponentDesigner : StiComponentDesigner
	{
		/// <summary>
		/// Invokes a component designer.
		/// </summary>
		/// <param name="component">Component for edition.</param>
		/// <returns>The result of invokes the component designer.</returns>
		public override DialogResult Design(StiComponent component)
		{
			using (MyCustomComponentDesignerForm form = new MyCustomComponentDesignerForm())
			{
				return form.ShowDialog();
			}
			
		}


		/// <summary>
		/// Creates a new designer of the component.
		/// </summary>
		/// <param name="designer">Report designer.</param>
		public MyCustomComponentDesigner(IStiDesignerBase designer)
			: base(designer)
		{

		}
	}
}
