using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.Enumerations
{
    [DataContract]
    public enum CartPreferred
    {
        [EnumMember]
        Any = 0,

        [EnumMember]
        Walk = 1,

        [EnumMember]
        Cart = 2
    }
}
