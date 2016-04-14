using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.Enumerations
{
    /// <summary>
    /// Represents a day of the week to be used by a customer's preferred tee time list.
    /// </summary>
    [DataContract]
    public enum WeekDay
    {
        [EnumMember]
        Saturday = 0,

        [EnumMember]
        Sunday = 1,

        [EnumMember]
        Monday = 2,

        [EnumMember]
        Tuesday = 3,

        [EnumMember]
        Wednesday = 4,

        [EnumMember]
        Thursday = 5,

        [EnumMember]
        Friday = 6
    }
}
