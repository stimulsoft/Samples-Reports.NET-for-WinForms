using System;
using System.Drawing;
using System.ComponentModel;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Base.Serializing;
using Stimulsoft.Base.Services;
using Stimulsoft.Base.Localization;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Engine;
using Stimulsoft.Report.Painters;
using Stimulsoft.Report.Components.Design;

namespace CustomComponents
{
	[StiServiceBitmap(typeof(MyCustomComponent), "CustomComponents.MyCustomComponent1.gif")]
	[StiToolbox(true)]
	[StiContextTool(typeof(IStiShift))]
	[StiContextTool(typeof(IStiGrowToHeight))]
	[StiDesigner(typeof(MyCustomComponentDesigner))]
    [StiV1Builder(typeof(MyCustomComponentV1Builder))]
    [StiV2Builder(typeof(MyCustomComponentV2Builder))]
    [StiGdiPainter(typeof(MyCustomComponentGdiPainter))]
	public class MyCustomComponent : StiComponent, IStiBorder, IStiBrush
	{
		#region StiComponent override
		/// <summary>
		/// Gets value to sort a position in the toolbox.
		/// </summary>
		public override int ToolboxPosition
		{
			get
			{
				return 500;
			}
		}

		/// <summary>
		/// Gets a localized name of the component category.
		/// </summary>
		public override string LocalizedCategory
		{
			get 
			{
				return StiLocalization.Get("Report", "Components");
			}
		}

		
		/// <summary>
		/// Gets a localized component name.
		/// </summary>
		public override string LocalizedName
		{
			get 
			{
				return "MyCustomComponent1";
			}
		}
		#endregion

		#region IStiBorder
		private StiBorder border = new StiBorder();
		/// <summary>
		/// Gets or sets frame of the component.
		/// </summary>
		[StiCategory("Appearance")]
		[StiSerializable]
		[Description("Gets or sets frame of the component.")]
		public StiBorder Border
		{
			get 
			{
				return border;
			}
			set 
			{
				border = value;
			}
		}
		#endregion

		#region IStiBrush
		private StiBrush brush = new StiSolidBrush(Color.Transparent);
		/// <summary>
		/// Gets or sets a brush to fill a component.
		/// </summary>
		[StiCategory("Appearance")]
		[StiSerializable]
		[Description("Gets or sets a brush to fill a component.")]
		public StiBrush Brush
		{
			get 
			{
				return brush;
			}
			set 
			{
				brush = value;
			}
		}
		#endregion

		#region this
		/// <summary>
		/// Creates a new component of the type MyCustomComponent.
		/// </summary>
		public MyCustomComponent() : this(RectangleD.Empty)
		{
		}

		/// <summary>
		/// Creates a new component of the type MyCustomComponent.
		/// </summary>
		/// <param name="rect">The rectangle describes size and position of the component.</param>
		public MyCustomComponent(RectangleD rect) : base(rect)
		{
			PlaceOnToolbox = true;
		}
		#endregion
	}
}
