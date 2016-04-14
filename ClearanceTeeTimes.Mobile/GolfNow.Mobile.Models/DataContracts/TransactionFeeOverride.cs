using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Base class for transaction fee discounts/alterations. Its child classes should be used to impact transaction fees.
    /// </summary>
    [DataContract]
    [KnownType(typeof(TransactionFeeWaiveOverride))]
    [KnownType(typeof(TransactionFeeAlterationOverride))]
    public class TransactionFeeOverride
    {
    }
}
