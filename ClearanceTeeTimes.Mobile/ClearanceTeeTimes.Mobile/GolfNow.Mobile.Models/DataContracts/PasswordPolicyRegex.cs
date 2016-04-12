using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A summary of a password policy, with a description of the policy and the regular expression that programatically validates it.
    /// </summary>
    [DataContract]
    public class PasswordPolicyRegex
    {
        /// <summary>
        /// A description of the password policy.
        /// </summary>
        [DataMember]
        public string PolicyDescription
        {
            get;
            set;
        }

        /// <summary>
        /// A regular expression used to validate this particular password policy.
        /// </summary>
        [DataMember]
        public string PolicyRegularExpression
        {
            get;
            set;
        }
    }
}
