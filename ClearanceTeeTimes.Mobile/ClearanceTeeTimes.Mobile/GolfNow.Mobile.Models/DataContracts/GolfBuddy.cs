using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A data contract for golf buddies.
    /// </summary>
    [DataContract]
    public class GolfBuddy
    {
        public GolfBuddy()
        {
        }

        /// <summary>
        /// Gets or sets the golf buddy's first name.
        /// </summary>
        [DataMember]
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the golf buddy's last name.
        /// </summary>
        [DataMember]
        public string LastName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the golf buddy's email address.
        /// </summary>
        [DataMember]
        public string EMailAddress
        {
            get;
            set;
        }
    }

}
