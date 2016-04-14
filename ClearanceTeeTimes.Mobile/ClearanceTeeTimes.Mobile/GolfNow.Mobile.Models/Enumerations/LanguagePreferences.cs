using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.Enumerations
{
    /// <summary>
    /// Specification for a change in email language preference for a customer.
    /// </summary>
    [DataContract]
    public enum LanguagePreferences : int
    {
        /// <summary>
        /// Change the language preferences for a customer to English.
        /// </summary>
        [EnumMember]
        English = 0,

        /// <summary>
        /// Change the language preferences for a customer to Canadian French.
        /// </summary>
        [EnumMember]
        FrenchCanadian = 1
    }
}
