using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// When implemented, contains information about a payment method in the GolfNow system.
    /// </summary>
    [KnownType(typeof(SavedCreditCardInfo))]
    [KnownType(typeof(AccountBalanceRemaining))]
    [DataContract]
    public abstract class SavedPaymentInfo
    {
    }
}
