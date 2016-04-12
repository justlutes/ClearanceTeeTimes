using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Information pertaining to a particular tee time reservation.
    /// </summary>
    [DataContract]
    public class ReservationConfirmation
    {
        /// <summary>
        /// Gets or sets the reservation id.
        /// </summary>
        [DataMember]
        public int? ReservationID
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets or sets the inventory channel id.
        /// </summary>
        [DataMember]
        public int InventoryChannelID
        {
            get;
            set;
        }
                
        /// <summary>
        /// Gets or sets the confirmation number associated with the reservation.
        /// </summary>
        [DataMember]
        public string ConfirmationNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the invoice used to book the reservation.
        /// </summary>
        [DataMember]
        public TeeTimeInvoice Invoice
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a list of buddies that were associated with the reservation.
        /// </summary>
        [DataMember]
        public List<GolfBuddyDetails> Buddies
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets tee time reservation status.
        /// </summary>
        [DataMember]
        public Enumerations.ReservationStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets credit cards used with the reservation
        /// </summary>
        [DataMember]
        public SavedPaymentInfo[] Payments
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets whether the facility associated with this reservation is available for further information
        /// extraction.
        /// </summary>
        [DataMember]
        public bool FacilityDetailAvailable
        {
            get;
            set;
        }
    }
}
