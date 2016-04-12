using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Represents a Saved Credit Card Payment used in previous booking and saved for future use
    /// </summary>
    [DataContract]
    public class SavedCreditCardPayment : PaymentInfo
    {
        /// <summary>
        /// Gets or sets the amount to be paid on saved card.
        /// </summary>
        [DataMember]
        public decimal Amount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the amount to be paid on saved card.
        /// </summary>
        [DataMember]
        public int? PaymentOptionID
        {
            get;
            set;
        }


    }
}
