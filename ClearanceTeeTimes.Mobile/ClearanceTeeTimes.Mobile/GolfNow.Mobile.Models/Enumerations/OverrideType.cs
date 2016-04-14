using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.Enumerations
{
    /// <summary>
    /// The means by which to utilize the "Amount" parameter in a tee time override.
    /// </summary>
    [DataContract]
    public enum OverrideType
    {
        /// <summary>
        /// This is for validation purposes and should not be used by the client: the API will reject
        /// override fields with this value.
        /// </summary>
        [EnumMember]
        None,

        /// <summary>
        /// Use the "Amount" field as a percentage.
        /// </summary>
        [EnumMember]
        Percentage,

        /// <summary>
        /// Subtract a flat amount from the referent parameter, using the "Amount" field.
        /// </summary>
        [EnumMember]
        FlatDiscount,

        /// <summary>
        /// Change the referent tee time metric to be exactly "Amount".
        /// </summary>
        [EnumMember]
        FlatRate
    }
}
