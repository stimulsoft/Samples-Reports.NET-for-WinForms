using System;
using System.Drawing.Design;
using System.Text;
using System.ComponentModel;
using Stimulsoft.Report.Events;
using Stimulsoft.Report.Components;

namespace CustomComponents
{
	[TypeConverter(typeof(StiCustomCodeExpressionConverter))]
	public class StiCustomCodeExpression : StiUnifiedExpression
	{
		[Browsable(false)]
		public override bool ApplyFormat
		{
			get
			{
				return false;
			}
		}

		/// <summary>
		/// Returns the event for processing of the expession when generation the report script.
		/// </summary>
		/// <returns>The event for processing of the expession.</returns>
		public override StiEvent GetDefaultEvent()
		{
			return new StiGetCustomCodeEvent();
		}


		/// <summary>
		/// Gets value, indicates that this value is be a string.
		/// </summary>
		public override bool FullConvert
		{
			get
			{
				return false;
			}
		}


		/// <summary>
		/// Creates a new expression.
		/// </summary>
		public StiCustomCodeExpression() : this(string.Empty)
		{
		}


		/// <summary>
		/// Creates a new expression.
		/// </summary>
		/// <param name="val">Expression value.</param>
		public StiCustomCodeExpression(string value) : base(value)
		{
			
		}

		/// <summary>
		/// Creates a new expression.
		/// </summary>
        public StiCustomCodeExpression(StiComponent parent, string propertyName)
            : base(parent, propertyName)
		{
		}
	}
}
