using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Represents an address for an entity.
    /// </summary>
    [DataContract]
    public class Address
    {
        /// <summary>
        /// Gets or sets line one of the customer address.
        /// </summary>
        [DataMember]
        public string Line1
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets line two of the customer address.
        /// </summary>
        [DataMember]
        public string Line2
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the city name for the address.
        /// </summary>
        [DataMember]
        public string City
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a valid state provence code for the address.
        /// </summary>
        [DataMember]
        public string StateProvinceCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a valid postal code for the address.
        /// </summary>
        [DataMember]
        public string PostalCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a valid country code for the address.
        /// </summary>
        [DataMember]
        public string Country
        {
            get;
            set;
        }
    }
}
