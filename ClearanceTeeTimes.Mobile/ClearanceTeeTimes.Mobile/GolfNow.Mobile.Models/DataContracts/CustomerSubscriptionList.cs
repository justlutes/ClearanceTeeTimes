using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A representation of a customer subscription list which groups subscribed customers together for specific marketing campaigns.
    /// </summary>
    [DataContract]
    public class CustomerSubscriptionList
    {
        /// <summary>
        /// The ID of the customer subscription list.
        /// </summary>
        [DataMember]
        public int ID
        {
            get;
            set;
        }

        /// <summary>
        /// The friendly name of the customer subscription list.
        /// </summary>
        [DataMember]
        public string Name
        {
            get;
            set;
        }
    }
}
