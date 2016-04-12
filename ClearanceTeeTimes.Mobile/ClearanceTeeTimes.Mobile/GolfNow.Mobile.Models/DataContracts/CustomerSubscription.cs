using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    [DataContract]
    public class CustomerSubscription : Subscription
    {
        [DataMember]
        public string IsSubscribed
        {
            get;
            set;
        }
    }
}
