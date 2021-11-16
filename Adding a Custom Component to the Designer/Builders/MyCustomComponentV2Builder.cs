using System;
using Stimulsoft.Report.Engine;
using Stimulsoft.Report.Components;

namespace Adding_a_Custom_Component_to_the_Designer
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
