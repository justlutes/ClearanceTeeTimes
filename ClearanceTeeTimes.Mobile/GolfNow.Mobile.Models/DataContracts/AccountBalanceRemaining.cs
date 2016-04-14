using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A contract summarizing the account balance accumulated through GolfNow gift cards.
    /// </summary>
    [DataContract]
    public class AccountBalanceRemaining : SavedPaymentInfo
    {
        /// <summary>
        /// The remaining balance of account credit for a customer.
        /// </summary>
        [DataMember]
        public decimal CurrentBalance
        {
            get;
            set;
        }
    }
}
