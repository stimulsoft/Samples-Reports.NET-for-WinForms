using System;
using System.Drawing;
using System.ComponentModel;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Base.Serializing;
using Stimulsoft.Base.Services;
using Stimulsoft.Base.Localization;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Events;
using Stimulsoft.Report.Components.Design;
using Stimulsoft.Base.Json.Linq;
using Stimulsoft.Base;

namespace Adding_a_Custom_Component_to_the_Designer
{
	[StiServiceBitmap(typeof(MyCustomComponent2), "Adding_a_Custom_Component_to_the_Designer.MyCustomComponent4.gif")]
	[StiToolbox(true)]
	[StiContextTool(typeof(IStiShift))]
	[StiContextTool(typeof(IStiGrowToHeight))]
	[StiDesigner(typeof(MyCustomComponent2Designer))]
	public class MyCustomComponent2 : StiComponent, IStiBorder, IStiBrush
	{
        #region IStiJsonReportObject.override
        public override JObject SaveToJsonObject(StiJsonSaveMode mode)
        {
            var jObject = base.SaveToJsonObject(mode);

            jObject.AddPropertyBrush(nameof(Brush), Brush);
            jObject.AddPropertyBorder(nameof(Border), Border);

            return jObject;
        }

        public override void LoadFromJsonObject(JObject jObject)
        {
            base.LoadFromJsonObject(jObject);

            foreach (var property in jObject.Properties())
            {
                switch (property.Name)
                {
                    case nameof(Brush):
                        Brush = property.DeserializeBrush();
                        break;

                    case nameof(Border):
                        Border = property.DeserializeBorder();
                        break;
                }
            }
        }
        #endregion

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
				return "MyCustomComponent4";
			}
		}
		#endregion

		#region Render override
		/// <summary>
		/// Rendering of the component without events.
		/// </summary>
		/// <param name="renderedComponent">Rendered component.</param>
		/// <param name="outContainer">Panel in which rendering will be done.</param>
		/// <returns>Is rendering finished or not.</returns>
		protected override bool RenderComponent(ref StiComponent renderedComponent, StiContainer outContainer)
		{
			MyCustomComponent2 component = (MyCustomComponent2)this.Clone();
			component.InvokeEvents();		
			outContainer.Components.Add(component);
			renderedComponent = component;
			return true;
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

		#region Paint
		/// <summary>
		/// Paints a component.
		/// </summary>
		/// <param name="e">Argument for painting.</param>
		public override void Paint(StiPaintEventArgs e)
		{
			InvokePainting(this, e);
			
			if (!e.Cancel)
			{			
				Graphics g = e.Graphics;

				RectangleD rect = GetPaintRectangle();
				if (rect.Width > 0 && rect.Height > 0 && (e.ClipRectangle.IsEmpty || rect.IntersectsWith(e.ClipRectangle)))
				{
					#region Fill rectangle
					if (this.Brush is StiSolidBrush && 
						((StiSolidBrush)this.Brush).Color == Color.Transparent && 
						Report.Info.FillComponent &&
						IsDesigning)
					{
						Color color = Color.FromArgb(150, Color.Green);

						StiDrawing.FillRectangle(g, color, rect.Left, rect.Top, rect.Width, rect.Height);
					}
					else StiDrawing.FillRectangle(g, Brush, rect);
					#endregion

					//******************
					//Draw control
					//******************

					#region Markers
					PaintMarkers(g, rect);
					#endregion

					#region Border
					if (this.HighlightState == StiHighlightState.Hide)
						Border.Draw(g, rect, Page.Zoom);
					#endregion

					PaintEvents(e.Graphics, rect);
				}
			}
			e.Cancel = false;
			InvokePainted(this, e);

		}
		#endregion

		#region ICloneable override
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public override object Clone()
		{
			return base.Clone();
		}
		#endregion

		#region this
		/// <summary>
		/// Creates a new component of the type MyCustomComponent2.
		/// </summary>
		public MyCustomComponent2() : this(RectangleD.Empty)
		{
		}

		/// <summary>
		/// Creates a new component of the type MyCustomComponent2.
		/// </summary>
		/// <param name="rect">The rectangle describes size and position of the component.</param>
		public MyCustomComponent2(RectangleD rect) : base(rect)
		{
			PlaceOnToolbox = true;
		}
		#endregion
	}
}
