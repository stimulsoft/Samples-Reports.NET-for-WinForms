using System;
using System.ComponentModel;
using Stimulsoft.Report.CodeDom;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Events;

namespace Adding_a_Custom_Component_to_the_Designer
{
	[TypeConverter(typeof(StiGetCustomCodeEventConverter))]
	public class StiGetCustomCodeEvent : StiEvent
	{

		/// <summary>
		/// Returns an array of event parameters.
		/// </summary>
		/// <returns>Array of event parameters.</returns>
		public override StiParameterInfo[] GetParameters()
		{
			return new StiParameterInfo[]{
											 new StiParameterInfo(typeof(object), "sender"),
											 new StiParameterInfo(typeof(StiValueEventArgs), "e")};
		}

		/// <summary>
		/// Return the type of the event.
		/// </summary>
		/// <returns>Event type.</returns>
		public override Type GetEventType()
		{
			return typeof(StiValueEventHandler);
		}

		/// <summary>
		/// Returns the string representation of the event.
		/// </summary>
		public override string ToString()
		{
			return "GetCustomCode";
		}

		/// <summary>
		/// Creates a new object of the type StiGetZipCodeEvent.
		/// </summary>
		public StiGetCustomCodeEvent() : this("")
		{
		}

		/// <summary>
		/// Creates a new object of the type StiGetZipCodeEvent with specified arguments.
		/// </summary>
		/// <param name="script">Script of the event.</param>
		public StiGetCustomCodeEvent(string script) : base(script)
		{
		}

		/// <summary>
		/// Creates a new object of the type StiEvent with specified arguments.
		/// </summary>
		/// <param name="parent">Component which contain this event.</param>
        public StiGetCustomCodeEvent(StiComponent parent)
            : base(parent)
		{
		}
	}
}
