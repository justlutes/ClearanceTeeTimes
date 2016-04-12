using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Api
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate,Inherited = true, AllowMultiple = true)]
	public class PreserveAttribute : Attribute
	{
		#pragma warning disable 0649
		//
		// Fields
		//
		public bool AllMembers {get;set;}

		public bool Conditional{get;set;}
		#pragma warning restore 0649
	}
}

