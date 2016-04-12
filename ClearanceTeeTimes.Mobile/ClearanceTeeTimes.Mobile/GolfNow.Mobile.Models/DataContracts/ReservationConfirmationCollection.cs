using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A collection of reservations.
    /// </summary>
    [DataContract]
    public class ReservationConfirmationCollection
    {
        /// <summary>
        /// The reservations that match the query.
        /// </summary>
        [DataMember]
        public ReservationConfirmation[] Reservations { get; set; }

        /// <summary>
        /// An optional set of facilities that match the query.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public Expandable<FacilityDetail[]> Facilities
        {
            get;
            set;
        }

        /// <summary>
        /// The total number of reservations that matched the query (reguardless of the paging options).
        /// </summary>
        [DataMember]
        public int TotalReservations
        {
            get;
            set;
        }

    }
}
