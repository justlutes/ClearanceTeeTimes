using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    [TrackHit("RateHit", "TrackRateHits")]
    public class TeeTimeRateset : TeeTime
    {
        /// <summary>
        /// Gets or sets a list of rates available for this tee time.
        /// </summary>
        [DataMember]
        public TeeTimeRate[] Rates
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a bitwise representation of the player rule describing the number of players allowed to book this tee time.  
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
                PlayerRule = value.ConvertIntToEnum<PlayerRule>("PlayerRule");
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this tee time has a rate that is considered a hot deal.
        /// </summary>
        /// <value>
        /// <c>true</c> if this tee time has hot deal rate; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool HasHotDealRate { get; set; }

        /// <summary>
        /// Gets or sets the rate to display to the customer.
        /// </summary>
        /// <value>
        /// The display rate.
        /// </value>
        [DataMember]
        public TeeTimeRate DisplayRate { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Facility {0} | Time {1:MM-dd-yyyy hh:mm:ss} | Total Rates {2} | Has More Rates {3}", 
                this.FacilityID, 
                this.Time, 
                this.Rates.Count(),
                HasMoreRates);
        }

        /// <summary>
        /// Used for tracking rate hits.
        /// </summary>
        public object[] TrackRateHits()
        {
            return Rates.Select(a => new Helpers.TeeTimeRateHit()
            {
                TeeTimeRateID = a.TeeTimeRateID,
                GreenFees = a.SinglePlayerPrice.GreensFees
            }).ToArray();
        }

        /// <summary>
        /// <c>true</c> if this tee time has more rates; otherwise, <c>false</c>.
        /// </summary>
        [DataMember]
        public bool HasMoreRates { get; set; }
    }
}
