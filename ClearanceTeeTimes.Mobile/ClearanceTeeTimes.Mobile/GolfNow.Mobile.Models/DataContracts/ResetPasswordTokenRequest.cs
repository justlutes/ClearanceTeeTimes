using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// An object summarizing a request to reset a password.
    /// </summary>
    [DataContract]
    public class ResetPasswordTokenRequest
    {
        /// <summary>
        /// The encoded token encapsulating for whom this request is for, as well as certain
        /// other validation parameters
        /// </summary>
        [DataMember]
        [XSSIntrusionPreventionIgnore]
        public string Token { get; set; }

        /// <summary>
        ///  The new password for this customer.
        /// </summary>
        [DataMember]
        public string NewPassword { get; set; }
    }
}
