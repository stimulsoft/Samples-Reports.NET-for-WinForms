using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;
using System.Drawing.Imaging;

using Stimulsoft.Report;
using Stimulsoft.Report.CodeDom;
using Stimulsoft.Base;
using Stimulsoft.Base.Services;
using Stimulsoft.Base.Serializing;
using Stimulsoft.Base.Localization;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report.Units;
using Stimulsoft.Report.Events;
using Stimulsoft.Report.Engine;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Components.Design;
using Stimulsoft.Report.Painters;


namespace CustomComponent
{
    /// <summary>
    /// Render builder for EngineV2
    /// </summary>
    public class MyCustomComponentV2Builder : StiComponentV2Builder
	{
		public override StiComponent InternalRender(StiComponent masterComp)
		{
            MyCustomComponent renderedComponent = base.InternalRender(masterComp) as MyCustomComponent;
			return renderedComponent;
		}
	}
}
