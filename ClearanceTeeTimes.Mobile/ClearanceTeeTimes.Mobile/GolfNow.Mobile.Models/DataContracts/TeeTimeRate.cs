using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    [DataContract]
    public class TeeTimeRate
    {
        /// <summary>
        /// Gets or sets the tee time rate id.
        /// </summary>
        [DataMember]
        public int TeeTimeRateID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the rate.
        /// </summary>
        [DataMember]
        public string RateName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the number of holes included in this rate.
        /// </summary>
        [DataMember]
        public int HoleCount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a single player's price at this rate.
        /// </summary>
        [DataMember]
        public TeeTimePrice SinglePlayerPrice
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether or not a credit card is required to book this rate.
        /// </summary>
        [DataMember]
        public bool? AcceptCreditCard
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
		/// A list of discounts applied to the tee time rate
		/// </summary>
		[DataMember]
		public Discount[] DiscountsApplied
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets a bitwise representation of the player rule describing the number of players allowed to book this tee 
        /// time rate.  
        /// </summary>
        /// <example>For example, a value of (decimal) 11 = (binary) 1011 means that 1, 2 or 4 players can book this tee time.</example>
        public PlayerRule PlayerRule
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a the integer value of PlayerRule used for serialization.
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
                PlayerRule = (PlayerRule)value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this rate is a hot deal.
        /// </summary>
        /// <value>
        /// <c>true</c> if this rate is a hot deal; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool IsHotDeal { get; set; }

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(this.RateName))
            {
                return string.Format("{0}: {1}", this.RateName, this.SinglePlayerPrice);
            }
            else
            {
                return string.Format("{0}", this.SinglePlayerPrice);
            }
        }
    }
}
