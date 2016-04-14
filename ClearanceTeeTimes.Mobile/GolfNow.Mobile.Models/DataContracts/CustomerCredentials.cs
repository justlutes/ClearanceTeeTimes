using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A data contract for customer credentials.
    /// </summary>
    [DataContract]
    public class CustomerCredentials
    {
        /// <summary>
        /// Gets or sets the customer's email address.
        /// </summary>
        [DataMember]
        public string EMail
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the customer's password.
        /// </summary>
        [DataMember]
        [XSSIntrusionPreventionIgnoreAttribute]
        public string Password
        {
            get;
            set;
        }
    }
}
