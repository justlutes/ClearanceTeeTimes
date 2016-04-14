using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.Enumerations
{
    /// <summary>
    /// Represents a person's gender.
    /// </summary>
    [DataContract]
    public enum Gender : int
    {
        [EnumMember]
        Male = 0,

        [EnumMember]
        Female = 1
    }
}
