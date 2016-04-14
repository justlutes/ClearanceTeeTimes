using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using GolfNow.Mobile.Core.Models;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A data contract for a customer profile used for adding a new customer.
    /// </summary>
    [DataContract]
    public class CustomerProfileNew : CustomerProfile
    {
        /// <summary>
        /// The password for a new customer
        /// </summary>
        [DataMember]
        [XSSIntrusionPreventionIgnoreAttribute]
        public string Password
        {
            get;
            set;
        }

        /// <summary>
        /// A URL encoded value representing the registration source URL.
        /// </summary>
        [DataMember]
        public string RegistrationSourceURL { get; set; }

        /// <summary>
        /// A value representing an entity that referred this customer.  Used for tracking.
        /// </summary>
        [DataMember]
        public string ReferredBy { get; set; }
    }
}
