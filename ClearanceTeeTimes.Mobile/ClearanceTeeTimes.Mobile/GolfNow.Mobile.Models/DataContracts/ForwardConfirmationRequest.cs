using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Forward a reservation to a friend.
    /// </summary>
    [DataContract]
    public class ForwardConfirmationRequest : ConfirmationEmailRequest
    {
        /// <summary>
        /// The friend to forward to.
        /// </summary>
        [DataMember]
        public string ToEmailAddress
        {
            get;
            set;
        }

        /// <summary>
        /// Any comments from the user.
        /// </summary>
        [XSSIntrusionPreventionIgnore]
        [DataMember]
        public string Comments
        {
            get;
            set;
        }
    }
}
