using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// The information about a promo code that is to be given to a customer.
    /// </summary>
    [DataContract]
    public class PromoCodeInfo
    {
        /// <summary>
        /// The promo code type identifier.
        /// </summary>
        /// <remarks>This value must be a valid coupon ID from GolfNow.</remarks>
        [DataMember]
        public int CouponID { get; set; }

        /// <summary>
        /// The intended expiration date of the promo code that is provided to a customer.
        /// </summary>
        [DataMember]
        public DateTime? ExpirationDate { get; set; }
    }
}