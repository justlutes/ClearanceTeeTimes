using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.Enumerations
{
    [DataContract]
    public enum UserType
    {
        [EnumMember]
        Unknown = 0,

        [EnumMember]
        Senior = 300,

        [EnumMember]
        Student = 400,

        [EnumMember]
        Veteran = 500,
    }
}
