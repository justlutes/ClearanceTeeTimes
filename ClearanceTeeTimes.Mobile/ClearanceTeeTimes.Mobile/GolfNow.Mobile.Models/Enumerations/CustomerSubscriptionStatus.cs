using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.Enumerations
{
    /// <summary>
    /// A customer's subscription status to a particular customer subscription list.
    /// </summary>
    [DataContract]
    public enum CustomerSubscriptionStatus : int
    {
        [EnumMember]
        None = 0,

        [EnumMember]
        Subscribed = 1,

        [EnumMember]
        Unsubscribed = 2
    }
}
