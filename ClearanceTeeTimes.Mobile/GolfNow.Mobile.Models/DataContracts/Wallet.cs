using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{

    /// <summary>
    /// A collection of available payment options related to a customer
    /// </summary>
    [DataContract]
    public class Wallet
    {
        /// <summary>
        /// Gets or sets the credit cards.
        /// </summary>
        /// <value>
        /// The credit cards.
        /// </value>
        [DataMember]
        public List<CreditCardPaymentOption> CreditCards { get; set; }

        /// <summary>
        /// A collection of credit balances for a customer account by currency code
        /// </summary>
        /// <value>
        /// The credit balance for a customer account (by currency code)
        /// </value>
        [DataMember]
        public List<Money> AccountCredit { get; set; }
    }
}
