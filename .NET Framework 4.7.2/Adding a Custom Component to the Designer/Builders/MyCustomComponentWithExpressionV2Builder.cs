using System;
using Stimulsoft.Report.Engine;
using Stimulsoft.Report.Components;

namespace Adding_a_Custom_Component_to_the_Designer
{
    /// <summary>
    /// Render builder for EngineV2
    /// </summary>
    public class MyCustomComponentWithExpressionV2Builder : StiComponentV2Builder
	{
		public override StiComponent InternalRender(StiComponent masterComp)
		{
            MyCustomComponentWithExpression renderedComponent = base.InternalRender(masterComp) as MyCustomComponentWithExpression;
			return renderedComponent;
		}
	}
}
