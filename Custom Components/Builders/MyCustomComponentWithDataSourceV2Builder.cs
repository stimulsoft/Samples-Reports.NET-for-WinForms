using System;
using Stimulsoft.Report.Engine;
using Stimulsoft.Report.Components;

namespace CustomComponents
{
    /// <summary>
    /// Render builder for EngineV2
    /// </summary>
    public class MyCustomComponentWithDataSourceV2Builder : StiComponentV2Builder
	{
		public override StiComponent InternalRender(StiComponent masterComp)
		{
            MyCustomComponentWithDataSource renderedComponent = base.InternalRender(masterComp) as MyCustomComponentWithDataSource;
			return renderedComponent;
		}
	}
}
