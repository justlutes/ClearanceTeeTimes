using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    [DataContract]
    public class CreditCardPayment : PaymentInfo
    {
        /// <summary>
        /// Gets or sets a valid credit card number to use in the payment.
        /// </summary>
        [DataMember]
        public string CreditCardNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the expiration month of the credit card.
        /// </summary>
        [DataMember]
        public int ExpirationMonth
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the expiration year of the credit card.
        /// </summary>
        [DataMember]
        public int ExpirationYear
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the credit card's billing address.
        /// </summary>
        [DataMember]
        public Address BillingAddress
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CVV security code of the credit card.
        /// </summary>
        [DataMember]
        public string CVVCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets  the billing name associated with the credit card.
        /// </summary>
        [DataMember]
        public string BillingName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the amount to charge the card.
        /// </summary>
        [DataMember]
        public Money Amount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether or not to save the credit card for future use.
        /// </summary>
        [DataMember]
        public bool SaveCreditCard
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the customer's billing phone number.
        /// </summary>
        [DataMember]
        public string BillingPhoneNumber
        {
            get;
            set;
        }
    }
}
