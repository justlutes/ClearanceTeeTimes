using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Represents the details of a reservation.  These details can be used to cancel a reservation.
    /// </summary>
    [DataContract]
    public class ReservationDetail
    {
        /// <summary>
        /// The reservation identifier.  Also known to the customer as the reservation confirmation number.
        /// </summary>
        [DataMember]
        public int ReservationID { get; set; }

        /// <summary>
        /// The number of players for the reservation.
        /// </summary>
        [DataMember]
        public int Players { get; set; }

        /// <summary>
        /// The channel identifier.
        /// </summary>
        [DataMember]
        public int ChannelID { get; set; }

        /// <summary>
        /// The guest information.
        /// </summary>
        [DataMember]
        public GuestInfo GuestInfo { get; set; }
    }
}