using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.Enumerations
{
    [DataContract]
    public enum UserExperienceLevel
    {
        [EnumMember]
        Unknown = 0,

        [EnumMember]
        Beginner = 10,

        [EnumMember]
        Intermediate = 20,

        [EnumMember]
        Professional = 30,
    }
}
