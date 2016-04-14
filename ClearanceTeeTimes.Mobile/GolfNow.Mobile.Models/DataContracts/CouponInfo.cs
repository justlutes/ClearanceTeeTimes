using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Information about a loyalty rewards coupon code.
    /// </summary>
    [DataContract]
    public class CouponInfo
    {
        /// <summary>
        /// The promo code associated with the tier.
        /// </summary>
        [DataMember]
        public string PromoCode
        {
            get;
            set;
        }

        /// <summary>
        /// The date of the coupon's redemption. If it has not been redeemed or is not yet qualified, null.
        /// </summary>
        [IgnoreDataMember]
        public DateTime? RedeemedOn
        {
            get;
            set;
        }

        /// <summary>
        /// The formatted datetime for the redemption date.
        /// </summary>
        [DataMember(Name = "RedeemedOn")]
        private string RedeemedOnFormatted
        {
            get;
            set;
        }

        /// <summary>
        /// The date of the coupon's expiry. If it is not been qualified yet, null.
        /// </summary>
        [IgnoreDataMember]
        public DateTime? ExpiresOn
        {
            get;
            set;
        }

        /// <summary>
        /// The formatted datetime for the expiry date.
        /// </summary>
        [DataMember(Name = "ExpiresOn")]
        public string ExpiresOnFormatted
        {
            get;
            set;
        }

        /// <summary>
        /// The date upon which the coupon code became avaliable. If the number of reservations for qualification have not
        /// yet been met, null.
        /// </summary>
        [IgnoreDataMember]
        public DateTime? QualifiedOn
        {
            get;
            set;
        }

        /// <summary>
        /// The formatted datetime for the qualification date.
        /// </summary>
        [DataMember(Name="QualifiedOn")]
        private string QualifiedOnFormatted
        {
            get;
            set;
        }

        /// <summary>
        /// The amount of the discount imparted by this coupon code, or null if the coupon has not yet been acquired.
        /// </summary>
        [DataMember]
        public decimal? DiscountAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Formats the dates associated with the coupon on serialization.
        /// </summary>
        /// <param name="context"></param>
        [OnSerializing]
        private void OnSerializing(StreamingContext context)
        {
            this.ExpiresOnFormatted = this.ExpiresOn != null ? this.ExpiresOn.Value.ToFormattedString() : null;
            this.QualifiedOnFormatted = this.QualifiedOn != null ? this.QualifiedOn.Value.ToFormattedString() : null;
            this.RedeemedOnFormatted = this.RedeemedOn != null ? this.RedeemedOn.Value.ToFormattedString() : null;
        }

        /// <summary>
        /// Reinstates the dates associated with the coupon on deserialization.
        /// </summary>
        /// <param name="context"></param>
        [OnDeserialized]
        void OnDeserialized(StreamingContext context)
        {
            this.ExpiresOn = this.ExpiresOnFormatted.ToDateTime();
            this.QualifiedOn = this.QualifiedOnFormatted.ToDateTime();
            this.RedeemedOn = this.RedeemedOnFormatted.ToDateTime();
        }
    }
}
