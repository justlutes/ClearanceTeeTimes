using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Container for a list of promo codes returned from the API.
    /// </summary>
    [DataContract]
    public class PromoCodeCollection
    {
        /// <summary>
        /// Gets or sets the list of promo codes.
        /// </summary>
        /// <value>
        /// The promo codes.
        /// </value>
        [DataMember]
        public IEnumerable<PromoCode> PromoCodes { get; set; }
    }
}