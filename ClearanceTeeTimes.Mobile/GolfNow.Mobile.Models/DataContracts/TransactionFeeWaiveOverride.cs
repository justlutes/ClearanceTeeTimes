using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A shortcut class for waiving transaction fees entirely. When specified, the transaction fee alteration amount is translated into
    /// a 100% discount.
    /// </summary>
    [DataContract]
    public class TransactionFeeWaiveOverride : TransactionFeeOverride
    {
    }
}
