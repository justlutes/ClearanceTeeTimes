using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A POCO containing information about each rewards tier for a particular user.
    /// </summary>
    [DataContract]
    public class RewardsTiers
    {
        /// <summary>
        /// The tier name.
        /// </summary>
        [DataMember]
        public string TierName
        {
            get;
            set;
        }

        /// <summary>
        /// A description of the reward associated with this tier.
        /// </summary>
        [DataMember]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// The number of reservations required to receive this reward.
        /// </summary>
        [DataMember]
        public int NumberOfRequiredReservations
        {
            get;
            set;
        }

        /// <summary>
        /// The number of reservations remaining until the reward is applicable to this user - if 0, the reward
        /// has been obtained.
        /// </summary>
        [DataMember]
        public int NumberOfReservationsUntilReward
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies whether or not the coupon associated with the reward is available for use.
        /// </summary>
        [DataMember]
        public bool IsRedeemable
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies whether or not this tier has obtained enough bookings for the customer to eligible to receieve the reward.
        /// </summary>
        [DataMember]
        public bool IsQualified
        {
            get;
            set;
        }

        /// <summary>
        /// A container detailing information about the associated reward for this tier.
        /// </summary>
        [DataMember]
        public CouponInfo Info
        {
            get;
            set;
        }
    }
}
