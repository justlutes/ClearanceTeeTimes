using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using GolfNow.API.Contracts.WebFaults;

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
                ErrorCode = value.ConvertIntToEnum<ErrorCode>("ErrorCode");
            }
        }

    }
}
