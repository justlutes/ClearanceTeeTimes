using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
	/// <summary>
	/// A data contract for an individual top deal
	/// </summary>
	[DataContract]
	public class TopDeal
	{
		/// <summary>
		/// Gets or sets the id of the facility associated with the top deal.
		/// </summary>
		[DataMember]
		public int FacilityID
		{ 
			get; 
			set; 
		}

		/// <summary>
		/// Gets or sets the name of the facility associated with the top deal
		/// </summary>
		[DataMember]
		public string FacilityName
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the city of the facility associated with the top deal
		/// </summary>
		[DataMember]
		public string FacilityCity
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the state/prov of the facility associated with the top deal
		/// </summary>
		[DataMember]
		public string FacilityStateProv
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the thumbnail image path of the facility associated with the top deal
		/// </summary>
		[DataMember]
		public string FacilityThumbNailImagePath
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the greens fee associated with the top deal
		/// </summary>
		[DataMember]
		public Money GreensFee
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the discount percent associated with the top deal
		/// </summary>
		[DataMember]
		public decimal DiscountPercent
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the search url associated with the top deal
		/// </summary>
		[DataMember]
		public string SearchUrl
		{
			get;
			set;
		}
	}
}
