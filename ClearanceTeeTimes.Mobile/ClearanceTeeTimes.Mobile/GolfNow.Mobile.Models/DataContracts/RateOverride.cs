using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Defines a rate override: an object that allows one to reprice the given tee time.
    /// </summary>
    [DataContract]
    public class RateOverride
    {
        /// <summary>
        /// Changes to greens fees. If null, greens fees will be left unchanged.
        /// </summary>
        [DataMember]
        public GreensFeeOverride GreensFeeOverride
        {
            get;
            set;
        }

        /// <summary>
        /// Changes to transaction fees. If null, transaction fees will be left unchanged.
        /// </summary>
        [DataMember]
        public TransactionFeeOverride TransactionFeeOverride
        {
            get;
            set;
        }
    }
}
