using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Contains information about a credit card saved in our system.
    /// </summary>
    [DataContract]
    public class SavedCreditCardInfo : SavedPaymentInfo
    {
        /// <summary>
        /// The masked credit card number.
        /// </summary>
        [DataMember]
        public string MaskedCreditCardNumber
        {
            get;
            set;
        }

        /// <summary>
        /// The expiration month of the credit card.
        /// </summary>
        [DataMember]
        public int ExpirationMonth
        {
            get;
            set;
        }

        /// <summary>
        /// The expiration year of the credit card.
        /// </summary>
        [DataMember]
        public int ExpirationYear
        {
            get;
            set;
        }

        /// <summary>
        /// The type of credit card.
        /// </summary>
        [DataMember]
        public string CreditCardType
        {
            get;
            set;
        }

        /// <summary>
        /// The billing name of credit card.
        /// </summary>
        [DataMember]
        public string BillingName
        { 
            get;
            set; 
        }

        /// <summary>
        /// The billing address of credit card.
        /// </summary>
        [DataMember]
        public string Address
        {
            get;
            set;
        }

        /// <summary>
        /// The counry code of the credit card.
        /// </summary>
        [DataMember]
        public string CountryCode
        {
            get;
            set;
        }

        /// <summary>
        /// The postal code.
        /// </summary>
        [DataMember]
        public string PostalCode { get; set; }
    }
}
