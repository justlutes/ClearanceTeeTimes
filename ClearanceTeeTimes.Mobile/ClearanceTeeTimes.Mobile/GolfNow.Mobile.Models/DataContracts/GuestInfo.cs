using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// An object containing information not normally available during the reservation process, applicable to affiliate bookings (booking on
    /// a customer's behalf), and for guest checkouts (wherein no customer information is available).
    /// </summary>
    [DataContract]
    public class GuestInfo
    {
        /// <summary>
        /// The customer's first name.
        /// </summary>
        [DataMember]
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// The customer's last name.
        /// </summary>
        [DataMember]
        public string LastName
        {
            get;
            set;
        }

        /// <summary>
        /// The phone number for the customer.
        /// </summary>
        [DataMember]
        public string PhoneNumber
        {
            get;
            set;
        }

        /// <summary>
        /// The email address associated with the customer.
        /// </summary>
        [DataMember]
        public string EmailAddress
        {
            get;
            set;
        }
    }
}
