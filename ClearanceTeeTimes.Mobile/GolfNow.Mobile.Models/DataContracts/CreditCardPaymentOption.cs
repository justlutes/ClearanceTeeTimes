using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{

    /// <summary>
    /// A credit card payment option
    /// </summary>
    [DataContract]
    public class CreditCardPaymentOption : PaymentOptionBase
    {

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [DataMember]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the credit card number. This should only be filled in on an 'add' operation.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        [DataMember]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the expiration month.
        /// </summary>
        /// <value>
        /// The expiration month.
        /// </value>
        [DataMember]
        public string ExpirationMonth { get; set; }

        /// <summary>
        /// Gets or sets the expiration year.
        /// </summary>
        /// <value>
        /// The expiration year.
        /// </value>
        [DataMember]
        public string ExpirationYear { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        [DataMember]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        /// <value>
        /// The postal code.
        /// </value>
        [DataMember]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        /// <value>
        /// The country code.
        /// </value>
        [DataMember]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the last four digits of the credit card.
        /// </summary>
        /// <value>
        /// The last four.
        /// </value>
        [DataMember]
        public string LastFour { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is the default credit card.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is default; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool IsDefault { get; set; }
    }
}
