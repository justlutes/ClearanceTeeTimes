using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    [KnownType(typeof(CreditCardPayment))]
    [KnownType(typeof(SavedCreditCardPayment))]
    [KnownType(typeof(AffiliatePayment))]
    [KnownType(typeof(AccountCredit))]
    [KnownType(typeof(AmazonPayment))]
    public abstract class PaymentInfo
    {
    }
}
