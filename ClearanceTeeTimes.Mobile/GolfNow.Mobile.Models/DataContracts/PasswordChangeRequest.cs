using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Contains information necessary to change the customer's password on the system.
    /// </summary>
    [DataContract]
    public class PasswordChangeRequest
    {
        /// <summary>
        /// Gets or sets customer's current password.
        /// </summary>
        [DataMember]
        [XSSIntrusionPreventionIgnoreAttribute]
        public string CurrentPassword
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the new password for the customer.
        /// </summary>
        [DataMember]
        [XSSIntrusionPreventionIgnoreAttribute]
        public string NewPassword
        {
            get;
            set;
        }
    }
}
