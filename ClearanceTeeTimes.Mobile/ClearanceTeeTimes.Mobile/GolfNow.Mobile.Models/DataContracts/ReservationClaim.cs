using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    [DataContract]
    public class ReservationClaim
    {
        private List<PaymentInfo> _paymentinformation;

        /// <summary>
        /// A list of payment information pertaining the the reservation claim.
        /// </summary>
        [DataMember]
        public List<PaymentInfo> PaymentInformation
        {
            get
            {
                if (this._paymentinformation == null)
                {
                    this._paymentinformation = new List<PaymentInfo>();
                }
                return this._paymentinformation;
            }
            set
            {
                this._paymentinformation = value;
            }
        }

        /// <summary>
        /// The inventory channel ID associated with the claim.
        /// </summary>
        [DataMember]
        public int InventoryChannelID
        {
            get;
            set;
        }
        
        /// <summary>
        /// The tee time rate ID.
        /// </summary>
        [DataMember]
        public int TeeTimeRateID
        {
            get;
            set;
        }
        
        /// <summary>
        /// The invoice to use for the reservation.
        /// </summary>
        [DataMember]
        public TeeTimeInvoice Invoice
        {
            get;
            set;
        }
        
        /// <summary>
        /// The promotional code to use for the reservation.
        /// </summary>
        [DataMember]
        public string PromotionalCode
        {
            get;
            set;
        }

        /// <summary>
        /// Reservation notes to associate with the reservation.
        /// </summary>
        [DataMember]
        public string Notes
        {
            get;
            set;
        }

        /// <summary>
        /// A tracking code to use for the reservation.
        /// </summary>
        [DataMember]
        public string TrackingCode
        {
            get;
            set;
        }

        /// <summary>
        /// A list of buddies to associate with the reservation.
        /// </summary>
        [DataMember]
        public List<GolfBuddy> Buddies
        {
            get;
            set;
        }

        /// <summary>
        /// This field is deprecated. Use FirstName in the GuestInfo object instead.
        /// 
        /// An optional first name to associate with the reservation.  When used, this is the name that will appear on the tee sheet.  When null,
        /// the customer profile associated with the reservation will be used.
        /// </summary>
        [DataMember]
        [Obsolete("FirstName is deprecated. Use GuestInfo.FirstName instead.")]
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// This field is deprecated. Use LastName in the GuestInfo object instead. 
        /// 
        /// An optional last name to associate with the reservation.  When used, this is the name that will appear on the tee sheet.  When null,
        /// the customer profile associated with the reservation will be used.
        /// </summary>
        [DataMember]
        [Obsolete("LastName is deprecated. Use GuestInfo.LastName instead.")]
        public string LastName
        {
            get;
            set;
        }

        /// <summary>
        /// An object describing ancillary information concerning affiliate and guest bookings, concerning customer information upon whose
        /// behalf the booking is taking place, or information that would not generally be facilitated during a usual reservation workflow.
        /// </summary>
        [DataMember]
        public GuestInfo GuestInfo
        {
            get;
            set;
        }

        /// <summary>
        /// An optional affiliate tracking information if customer come from external sources and it is wanted to track current conversion. When null,
        /// no tracking will take effect.
        /// </summary>
        [DataMember]
        public Affiliate AffiliateTracking
        {
            get;
            set;
        }

        /// <summary>
        /// Override the price of a given tee time. Must have been provisioned by a call to RequestOverrideTeeTimeInvoice,
        /// and must be used by the same client user name that requested it.
        /// </summary>
        [DataMember]
        public string OverrideReferenceId
        {
            get;
            set;
        }

        /// <summary>
        /// The collection of donations to be processed during this reservation.
        /// </summary>
        [DataMember]
        public CharitableDonation[] Donations { get; set; }

        /// <summary>
        /// A collection of reservation metadata.
        /// </summary>
        [DataMember]
        public ReservationMetadata[] ReservationMetadata { get; set; }
    }
}
