using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.Enumerations
{
    /// <summary>
    /// Represents a range of times to be used for a customer's preferred tee time list.
    /// </summary>
    [DataContract]
    public enum TimeRange
    {
        [EnumMember]
        Before8A = 0,

        [EnumMember]
        Between8Aand10A = 1,

        [EnumMember]
        Between10Aand12P = 2,

        [EnumMember]
        Between12Pand2P = 3,

        [EnumMember]
        Between2Pand4P = 4,

        [EnumMember]
        Between4Pand6P =5,

        [EnumMember]
        After6P = 6,

        [EnumMember]
        AnyTime = 7
    }
}
