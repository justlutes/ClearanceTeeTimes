using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    [DataContract]
    public class LoyaltyStatus
    {
        /// <summary>
        /// Gets or sets whether or not the user has frequent golfer status.
        /// </summary>
        [DataMember]
        public bool IsFrequentGolfer
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the number of reservations for the user in the current calendar year.
        /// </summary>
        [DataMember]
        public int YearToDateReservationCount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the current loyalty tier for the customer.
        /// </summary>
        [DataMember]
        public string CurrentLoyaltyTierDescription
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a count of the user's pending loyalty transactions
        /// </summary>
        [DataMember]
        public int PendingTransactionCount
        {
            get;
            set;
        }
    }
}
