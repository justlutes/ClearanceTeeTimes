using System;

namespace GolfNow.Mobile.Models.WebFaults
{
    //using System.ServiceModel.Web;

    /// <summary>
    /// A web fault based on the legacy format.  For backwards compatibility.
    /// </summary>
    //[Serializable]
    [Obsolete("Remove this class with the next minor version of the API. GAP-593")]
    public class LegacyWebFault// : WebFaultException<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyWebFault"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="errorCode">The error code.</param>
        //public LegacyWebFault(string message, ErrorCode errorCode)
        //    : base(message , errorCode.GetHttpStatusCode())
        //{
        //    HResult = errorCode.GetErrorCode();
        //}
    }
}