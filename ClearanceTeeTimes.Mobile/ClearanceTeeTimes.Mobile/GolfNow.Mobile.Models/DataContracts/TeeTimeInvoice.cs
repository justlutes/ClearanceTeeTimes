using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    [DataContract]
    public class TeeTimeInvoice : TeeTime
    {
        /// <summary>
        /// The tee time rate identifier associated with this invoice.
        /// </summary>
        [DataMember]
        public int TeeTimeRateID
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the rate.
        /// </summary>
        [DataMember]
        [XSSIntrusionPreventionIgnore]
        public string RateName
        {
            get;
            set;
        }

        /// <summary>
        /// The promo code that was applied to the tee time of this invoice or NULL if no promo code was applied.
        /// </summary>
        [DataMember]
        public string PromoCodeApplied
        {
            get;
            set;
        }

        /// <summary>
        /// The number of players for this invoice.
        /// </summary>
        [DataMember]
        public int PlayerCount
        {
            get;
            set;
        }

        /// <summary>
        /// The total reservation price for this invoice.
        /// </summary>
        [DataMember]
        public Money TotalReservationPrice
        {
            get;
            set;
        }

        /// <summary>
        /// The tee time pricing for this invoice.  This is the price of the tee time whether or not a discount has been applied
        /// and should be used when displaying pricing for a tee time.
        /// </summary>
        [DataMember]
        public TeeTimePrice Pricing
        {
            get;
            set;
        }

        /// <summary>
        /// Represents whether or not the transaction fees are waived for this transaction.
        /// </summary>
        [DataMember]
        public bool TransactionFeeWaived
        {
            get;
            set;
        }

        /// <summary>
        /// The pre-discount pricing for the invoice when a promo code or loyalty discount is applied.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public TeeTimePrice PreDiscountPricing
        {
            get;
            set;
        }

        /// <summary>
        /// A collection of discounts that have been applied to the tee time price.  This can include discounts due to loyalty,
        /// a promo code being applied or the discount off the retail rate.
        /// </summary>
        [DataMember]
        public Discount[] DiscountsApplied
        {
            get;
            set;
        }

        /// <summary>
        /// The notes for this tee time.
        /// </summary>
        [DataMember]
        [XSSIntrusionPreventionIgnore]
        public string TeeTimeNotes
        {
            get;
            set;
        }

        /// <summary>
        /// The facility terms and conditions.
        /// </summary>
        [DataMember]
        [XSSIntrusionPreventionIgnore]
        public string TermsAndConditions
        {
            get;
            set;
        }

        /// <summary>
        /// The message for a successfully applied promo code.
        /// </summary>
        [DataMember]
        [XSSIntrusionPreventionIgnore]
        public string PromoCodeSuccessMessage
        {
            get; 
            set;
        }

        /// <summary>
        /// A bitwise representation of the player rule describing the number of players allowed to book this tee time.  
        /// </summary>
        /// <example>For example, a value of (decimal) 11 = (binary) 1011 means that 1, 2 or 4 players can book this tee time.</example>
        public PlayerRule PlayerRule
        {
            get;
            set;
        }

        /// <summary>
        /// The integer value of PlayerRule used for serialization.
        /// </summary>
        [DataMember(Name = "PlayerRule")]
        private int PlayerRuleInt
        {
            get
            {
                return (int)PlayerRule;
            }
            set
            {
                // TODO: ConvertIntToEnum doesn't work for byte Enum. Don't know how it does for TeetimeRateSet, revisit here
                PlayerRule = (PlayerRule)Enum.ToObject(typeof(PlayerRule), value);
            }
        }

        /// <summary>
        /// The number of holes included in this rate.
        /// </summary>
        [DataMember]
        public int HoleCount
        {
            get;
            set;
        }

        /// <summary>
        /// A list of rate tag codes that apply to this tee time rate.  For example: PPO means "Hot Deals".
        /// </summary>
        [DataMember]
        public string[] RateTagCodes
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies whether or not this rate is a hot deal.
        /// </summary>
        [DataMember]
        public bool IsHotDeal
        {
            get;
            set;
        }

        /// <summary>
        /// The message returned if the rate for this invoice is restricted.  If this value is NULL, the rate is not restricted.
        /// </summary>
        [DataMember]
        public string RestrictedRateMessage { get; set; }

        public override string ToString()
        {
            return string.Format("Total Price {0} | PromoCode? {1}", this.TotalReservationPrice, !string.IsNullOrWhiteSpace(this.PromoCodeApplied));
        }
    }
}
