using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A data contract describing a customer's public user information
    /// </summary>
    [DataContract]
    public class UserInfo
    {
        /// <summary>
        /// Gets or sets a value containing the customers globally unique identifier
        /// </summary>
        [DataMember]
        public string CustomerGuid
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value containing the customers username
        /// </summary>
        [DataMember]
        public string UserName
        {
            get;
            set;
        }

    }
}
