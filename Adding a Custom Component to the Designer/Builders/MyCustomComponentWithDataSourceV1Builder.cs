using System;
using Stimulsoft.Report.Engine;
using Stimulsoft.Report.Components;

namespace Adding_a_Custom_Component_to_the_Designer
{
    /// <summary>
    /// Render builder for EngineV1
    /// </summary>
    public class MyCustomComponentWithDataSourceV1Builder : StiComponentV1Builder
	{
        public override bool InternalRender(StiComponent masterComp, ref StiComponent renderedComponent, StiContainer outContainer)
        {
            bool result = base.InternalRender(masterComp, ref renderedComponent, outContainer);

            return result;
        }
	}
}
