using System;
using System.Drawing;
using System.Drawing.Design;
using System.ComponentModel;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Base.Serializing;
using Stimulsoft.Base.Services;
using Stimulsoft.Base.Localization;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Events;
using Stimulsoft.Report.Engine;
using Stimulsoft.Report.Components.Design;

namespace Adding_a_Custom_Component_to_the_Designer
{
	[StiServiceBitmap(typeof(MyCustomComponentWithDataSource), "Adding_a_Custom_Component_to_the_Designer.MyCustomComponent2.gif")]
	[StiToolbox(true)]
	[StiContextTool(typeof(IStiShift))]
	[StiContextTool(typeof(IStiGrowToHeight))]
	[StiDesigner(typeof(MyCustomComponentDesigner))]
	[StiContextTool(typeof(IStiDataSource))]
    [StiV1Builder(typeof(MyCustomComponentWithDataSourceV1Builder))]
    [StiV2Builder(typeof(MyCustomComponentWithDataSourceV2Builder))]
	public class MyCustomComponentWithDataSource : StiComponent, IStiBorder, IStiBrush, IStiDataSource
	{
		#region IStiDataSource
		/// <summary>
		/// Get data source that is used for getting data.
		/// </summary>
		[Editor("Stimulsoft.Report.Components.Design.StiDataSourceEditor, Stimulsoft.Report.Design, " + StiVersion.VersionInfo, typeof(UITypeEditor))]
		[TypeConverter(typeof(StiDataSourceConverter))]
		[StiCategory("Data")]
		[Description("Get data source that is used for getting data.")]
		public virtual StiDataSource DataSource
		{
			get
			{
				if (Page == null || 
					Report == null || 
					Report.DataSources == null || 
					DataSourceName == null ||
					DataSourceName.Length == 0)return null;
				return Report.DataSources[DataSourceName];
			}
		}


		private string dataSourceName = string.Empty;
		[Browsable(false)]
		[StiSerializable]
			/// <summary>
			/// Gets or sets name of the Data Source.
			/// </summary>
		public string DataSourceName
		{
			get
			{
				return dataSourceName;
			}
			set
			{
				dataSourceName = value;
			}
		}
		#endregion

		#region IStiEnumerator
		[Browsable(false)]
		public bool IsDataSourceEmpty
		{
			get
			{
				return DataSourceName == null || DataSourceName.Length == 0 || DataSource == null;
			}
		}

		/// <summary>
		/// Sets the position at the beginning.
		/// </summary>
		public virtual void First()
		{
			if (this.DataSource != null)this.DataSource.First();
		}


		/// <summary>
		/// Move on the previous row.
		/// </summary>
		public virtual void Prior()
		{
			if (this.DataSource != null)this.DataSource.Prior();
		}


		/// <summary>
		/// Move on the next row.
		/// </summary>
		public virtual void Next()
		{
			if (this.DataSource != null)this.DataSource.Next();
		}


		/// <summary>
		/// Move on the last row.
		/// </summary>
		public virtual void Last()
		{
			this.DataSource.Last();
		}


		/// <summary>
		/// Gets value indicates that the position indicates to the end of data.
		/// </summary>
		[Browsable(false)]
		public virtual bool IsEof
		{
			get
			{
				if (DataSource != null)return DataSource.IsEof;
				else return true;
			}
			set
			{
				if (DataSource != null)DataSource.IsEof = value;
			}
		}


		/// <summary>
		/// Gets value, indicates that the position indicates to the beginning of data.
		/// </summary>
		[Browsable(false)]
		public virtual bool IsBof
		{
			get
			{
				if (DataSource != null)return DataSource.IsBof;
				return true;
			}
			set
			{
				if (DataSource != null)DataSource.IsBof = value;
			}
		}


		/// <summary>
		/// Gets value indicates that no data.
		/// </summary>
		[Browsable(false)]
		public virtual bool IsEmpty
		{
			get
			{
				if (DataSource != null)return DataSource.IsEmpty;
				return true;
			}
		}


		/// <summary>
		/// Gets the current position.
		/// </summary>
		[Browsable(false)]
		public virtual int Position
		{
			get
			{
				if (DataSource != null)return DataSource.Position;
				return 0;
			}
			set
			{
				if (DataSource != null)DataSource.Position = value;
			}
		}


		/// <summary>
		/// Gets count of rows.
		/// </summary>
		[Browsable(false)]
		public virtual int Count
		{
			get
			{
				if (DataSource != null)return DataSource.Count;
				return 0;
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
				return "MyCustomComponent2";
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
						Color color = Color.FromArgb(150, Color.GreenYellow);

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

		#region this
		/// <summary>
		/// Creates a new component of the type MyCustomComponentWithDataSource.
		/// </summary>
		public MyCustomComponentWithDataSource() : this(RectangleD.Empty)
		{
		}

		/// <summary>
		/// Creates a new component of the type MyCustomComponentWithDataSource.
		/// </summary>
		/// <param name="rect">The rectangle describes size and position of the component.</param>
		public MyCustomComponentWithDataSource(RectangleD rect) : base(rect)
		{
			PlaceOnToolbox = true;
		}
		#endregion
	}
}
