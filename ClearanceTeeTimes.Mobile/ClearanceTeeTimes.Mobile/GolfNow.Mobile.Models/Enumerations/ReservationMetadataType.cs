using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.Enumerations
{
    /// <summary>
    /// Defines reservation metadata entries. Currently the only supported flag are "RequiresEmailShareOptIn" (value: 1), "EmailOwnerID" (value 2)
    /// </summary>
    [DataContract]
    public enum ReservationMetadataType : short
    {
        [EnumMember]
        RequiresEmailShareOptIn = 1,
        [EnumMember]
        EmailOwnerID = 2
    }
}
