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
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Events;
using Stimulsoft.Report.Engine;
using Stimulsoft.Report.Components.Design;
using Stimulsoft.Report.Painters;

namespace CustomComponent
{

	[StiServiceBitmap(typeof(MyCustomComponentWithExpression), "CustomComponent.MyCustomComponent3.gif")]
	[StiToolbox(true)]
	[StiContextTool(typeof(IStiShift))]
	[StiContextTool(typeof(IStiGrowToHeight))]
	[StiDesigner(typeof(MyCustomComponentDesigner))]
    [StiV1Builder(typeof(MyCustomComponentWithExpressionV1Builder))]
    [StiV2Builder(typeof(MyCustomComponentWithExpressionV2Builder))]
    [StiGdiPainter(typeof(MyCustomComponentWithExpressionGdiPainter))]
	public class MyCustomComponentWithExpression : StiComponent
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
				return "MyCustomComponent3";
			}
		}
		#endregion

        #region Expressions
        #region Custom expression

        private string customCodeValue = null;
        [Browsable(false)]
        [StiSerializable(StiSerializeTypes.SerializeToDocument)]
        public string CustomCodeValue
        {
            get
            {
                return customCodeValue;
            }
            set
            {
                customCodeValue = value;
            }
        }


        [StiSerializable(
             StiSerializeTypes.SerializeToCode |
             StiSerializeTypes.SerializeToDesigner |
             StiSerializeTypes.SerializeToSaveLoad)]
        public virtual StiCustomCodeExpression CustomCode
        {
            get
            {
                return new StiCustomCodeExpression(this, "Code");
            }
            set
            {
                if (value != null) value.Set(this, "Code", value.Value);
            }
        }
        #endregion
        #endregion

        #region Events
        /// <summary>
        /// Invokes all events for this components.
        /// </summary>
        public override void InvokeEvents()
        {
            base.InvokeEvents();
            try
            {
                #region Code
                StiValueEventArgs e = new StiValueEventArgs();
                InvokeGetCustomCode(this, e);
                if (e.Value != null) this.customCodeValue = e.Value.ToString();
                #endregion
            }
            catch (Exception e)
            {
                StiLogService.Write(this.GetType(), "DoEvents...ERROR");
                StiLogService.Write(this.GetType(), e);

                if (Report != null)
                    Report.WriteToReportRenderingMessages(this.Name + " " + e.Message);
            }
        }


        #region GetCustomCode
        private static readonly object EventGetCustomCode = new object();

        public event StiValueEventHandler GetCustomCode
        {
            add
            {
                base.Events.AddHandler(EventGetCustomCode, value);
            }
            remove
            {
                base.Events.RemoveHandler(EventGetCustomCode, value);
            }
        }

        /// <summary>
        /// Raises the GetCustomCode event.
        /// </summary>
        protected virtual void OnGetCustomCode(StiValueEventArgs e)
        {
        }


        /// <summary>
        /// Raises the GetCustomCode event.
        /// </summary>
        public void InvokeGetCustomCode(StiComponent sender, StiValueEventArgs e)
        {
            try
            {
                OnGetCustomCode(e);
                StiValueEventHandler handler = base.Events[EventGetCustomCode] as StiValueEventHandler;
                if (handler != null) handler(sender, e);
            }
            catch (Exception ex)
            {
                string str = string.Format("Expression in CustomCode property of '{0}' can't be evaluated!", this.Name);
                StiLogService.Write(this.GetType(), str);
                StiLogService.Write(this.GetType(), ex.Message);
                Report.WriteToReportRenderingMessages(str);
            }
        }


        [StiSerializable]
        [StiCategory("ValueEvents")]
        [Browsable(false)]
        public StiGetCustomCodeEvent GetCustomCodeEvent
        {
            get
            {
                return new StiGetCustomCodeEvent(this);
            }
            set
            {
                if (value != null) value.Set(this, value.Script);
            }
        }
        #endregion
        #endregion

        #region this
        /// <summary>
		/// Creates a new component of the type MyCustomComponent.
		/// </summary>
		public MyCustomComponentWithExpression() : this(RectangleD.Empty)
		{
		}

		/// <summary>
		/// Creates a new component of the type MyCustomComponent.
		/// </summary>
		/// <param name="rect">The rectangle describes size and position of the component.</param>
        public MyCustomComponentWithExpression(RectangleD rect)
            : base(rect)
		{
			PlaceOnToolbox = true;
		}
		#endregion
	}
}
