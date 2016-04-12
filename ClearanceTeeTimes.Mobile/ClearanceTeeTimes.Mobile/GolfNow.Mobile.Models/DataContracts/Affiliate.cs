using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Represents affiliate values to be sent over tracking system. It contains unique user data for current transaction
    /// </summary>
    [DataContract]
    public class Affiliate
    {
        /// <summary>
        /// Gets or sets Advertiser Id to honor conversion
        /// </summary>
        [DataMember]
        public int? AdvertiserID 
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets customer unique request Id for tracking
        /// </summary>
        [DataMember]
        public string RequestID 
        { 
            get;
            set; 
        }

        /// <summary>
        /// Gets or sets associated tracking provider id
        /// </summary>
        [DataMember]
        public int? ProviderID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets associated tracking campaign id
        /// </summary>
        [DataMember]
        public string CampaignID 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// Gets or sets associated tracking offer id
        /// </summary>
        [DataMember]
        public string OfferID 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// Gets or sets associated tracking affiliate id
        /// </summary>
        [DataMember]
        public string AffiliateID 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// Gets or sets associated tracking event type
        /// </summary>
        [DataMember]
        public string EventID 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// Gets of sets associated tracking type
        /// </summary>
        [DataMember]
        public string Type
        {
            get;
            set;
        }
    }
}
