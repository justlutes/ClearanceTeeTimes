using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{

    /// <summary>
    /// The abstract payment option base
    /// </summary>
    [DataContract]
    [KnownType(typeof(CreditCardPaymentOption)), KnownType(typeof(GiftCardPaymentOption))]
    public abstract class PaymentOptionBase : PaymentInfo
    {
        /// <summary>
        /// Gets or sets the wallet option identifier.
        /// </summary>
        /// <value>
        /// The wallet option identifier.
        /// </value>
        [DataMember]
        public int WalletOptionId { get; set; }
    }
}
