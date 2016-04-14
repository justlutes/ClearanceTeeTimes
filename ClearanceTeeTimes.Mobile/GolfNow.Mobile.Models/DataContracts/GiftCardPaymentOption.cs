using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{

    /// <summary>
    /// A gift card payment option
    /// </summary>
    [DataContract]
    public class GiftCardPaymentOption : PaymentOptionBase
    {

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        [DataMember]
        public string Number { get; set; }
    }
}
