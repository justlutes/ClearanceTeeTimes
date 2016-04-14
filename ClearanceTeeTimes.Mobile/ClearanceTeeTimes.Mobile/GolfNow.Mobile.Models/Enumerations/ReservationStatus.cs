using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.Enumerations
{
    /// <summary>
    /// Describes tee time reservation status.
    /// </summary>
    [DataContract]
    public enum ReservationStatus : byte
    {
        [EnumMember]
        Cancelled = 0,
        [EnumMember]
        Reserved = 1
    }
}
