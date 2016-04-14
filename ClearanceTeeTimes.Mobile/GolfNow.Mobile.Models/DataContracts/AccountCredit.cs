using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using GolfNow.API.Contracts.WebFaults;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Represents a notification to the system to use gift cards as a form of payment that will be honored by the GolfNow system. 
    /// If the account type in question is a customer, this will use the existing balance against that account. If the account type in
    /// question is a guest, a collection of gift card payment options need to be included in order to be utilized.
    /// </summary>
    [DataContract]
    public class AccountCredit : PaymentInfo
    {
        [DataMember]
        public List<GiftCardPaymentOption> GuestGiftCards { get; set; }
    }
}
