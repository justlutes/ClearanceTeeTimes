using System.Runtime.Serialization;
using GolfNow.Mobile.Models.WebFaults;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A data contract for faults.
    /// </summary>
    [DataContract]
    public class FaultContract
    {
        /// <summary>
        /// The error code corresponding to the particular issue.
        /// </summary>
        public ErrorCode ErrorCode
        {
            get;
            set;
        }

        /// <summary>
        /// The developer's message for the error.
        /// </summary>
        [DataMember]
        public string Message
        {
            get;
            set;
        }

        /// <summary>
        /// The integer value of the error code
        /// </summary>
        [DataMember(Name = "ErrorCode")]
        private int ErrorCodeInt
        {
            get
            {
                return (int)ErrorCode;
            }
            set
            {
                ErrorCode = (ErrorCode)value;
            }
        }

    }
}
