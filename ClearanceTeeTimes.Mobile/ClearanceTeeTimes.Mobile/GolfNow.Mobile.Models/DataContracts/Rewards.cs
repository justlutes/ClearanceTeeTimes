using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A POCO containing information about the user's rewards.
    /// </summary>
    [DataContract]
    public class Rewards
    {
        /// <summary>
        /// The rewards year for the rewards in this object.
        /// </summary>
        [DataMember]
        public int RewardsYear
        {
            get;
            set;
        }

        /// <summary>
        /// The number of total qualified reservations made by this user for this rewards year.
        /// </summary>
        [DataMember]
        public int NumberOfQualifiedReservations
        {
            get;
            set;
        }

        /// <summary>
        /// Information about each tier for this rewards year for this user.
        /// </summary>
        [DataMember]
        public List<RewardsTiers> TierInfo
        {
            get;
            set;
        }
    }
}
