using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.Enumerations
{
    /// <summary>
    /// Describes player rules for a given tee time.  A player rule indicates the number players that are able to book this tee time.
    /// This is used as a bitwise representation of the payer rule.  So when the number is converted to its binary representation, 
    /// each bit represents a number of players able to book.  
    /// </summary>
    [DataContract]
    [Flags]
    public enum PlayerRule : byte
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        One = 1,
        [EnumMember]
        Two = 2,
        [EnumMember]
        Three = 4,
        [EnumMember]
        Four = 8
    }
}
