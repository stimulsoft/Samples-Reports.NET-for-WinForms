using System;
using System.Drawing;
using System.Windows.Forms;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Components.Design;
using Stimulsoft.Report.Design;

namespace CustomComponents
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
