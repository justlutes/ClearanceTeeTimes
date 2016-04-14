using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
	/// <summary>
	/// A data contract representing top deals
	/// </summary>
	[DataContract(Name="TopDeals")]
	public class TopDealsResponse
	{
		/// <summary>
		/// Gets or sets the top deals to be returned in the response
		/// </summary>
		[DataMember]
		public TopDeal[] Deals
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the hot deals url associated with the top deals
		/// </summary>
		[DataMember]
		public string HotDealsUrl
		{
			get;
			set;
		}
	}
}
