using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A promo code reward for a customer.
    /// </summary>
    [DataContract]
    public class PromoCode
    {
        /// <summary>
        /// Gets or sets the coupon identifier.
        /// </summary>
        /// <value>
        /// The coupon identifier.
        /// </value>
        [DataMember(Name="CouponID")]
        public int CouponId { get; set; }

        /// <summary>
        /// Gets or sets the value of the promo code.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [DataMember]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the name of the coupon.
        /// </summary>
        /// <value>
        /// The name of the coupon.
        /// </value>
        [DataMember]
        public string CouponName { get; set; }

        /// <summary>
        /// Gets or sets the expiration date of the promo code.
        /// </summary>
        /// <value>
        /// The expiration date.
        /// </value>
        [DataMember]
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Gets or sets the description of the coupon.
        /// </summary>
        /// <value>
        /// The coupon description.
        /// </value>
        [DataMember]
        public string CouponDescription { get; set; }

        /// <summary>
        /// Gets or sets the number of players this promo code can be used for.
        /// </summary>
        /// <value>
        /// The number of players.
        /// </value>
        [DataMember]
        public string NumberOfPlayers { get; set; }
    }
}