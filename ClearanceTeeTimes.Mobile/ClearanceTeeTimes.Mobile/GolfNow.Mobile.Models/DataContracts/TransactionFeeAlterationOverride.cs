using System;
using System.Runtime.Serialization;

using GolfNow.API.Contracts.Enumerations;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A transaction fee override encapsulating discounts and/or price alterations to transaction fees.
    /// </summary>
    [DataContract]
    public class TransactionFeeAlterationOverride : TransactionFeeOverride
    {
        /// <summary>
        /// The type of the waiver: flat rate, flat discount, or percentage.
        /// </summary>
        [DataMember]
        public OverrideType Type
        {
            get;
            set;
        }

        /// <summary>
        /// The amount by which to alter/discount the transaction fees.
        /// </summary>
        [DataMember]
        public decimal? Amount
        {
            get;
            set;
        }
    }
}
