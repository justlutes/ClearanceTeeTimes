using System;
using System.Runtime.Serialization;

using GolfNow.API.Contracts.Enumerations;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Alterations and/or discounts to greens fees.
    /// </summary>
    [DataContract]
    public class GreensFeeOverride
    {
        /// <summary>
        /// The type of the override: none, flat rate, flat discount, or percentage.
        /// </summary>
        [DataMember]
        public OverrideType Type
        {
            get;
            set;
        }

        /// <summary>
        /// The amount by which to alter/discount greens fees.
        /// </summary>
        [DataMember]
        public decimal? Amount
        {
            get;
            set;
        }
    }
}
