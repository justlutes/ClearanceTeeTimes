using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A data contract for guest credentials.
    /// </summary>
    [DataContract]
    public class GuestCredentials
    {
        /// <summary>
        /// Gets or sets the guest's email address.
        /// </summary>
        [DataMember]
        public string EMail
        {
            get;
            set;
        }
    }
}
