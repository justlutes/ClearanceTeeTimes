using System;
using System.Runtime.Serialization;
using GolfNow.Mobile.Models.Enumerations;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// An object to update a customer's email preferences.
    /// </summary>
    [DataContract]
    public class EmailPreferences
    {
        /// <summary>
        /// Set the language preferences for a customer. Currently, English (0) and Canadian French (1) are supported.
        /// </summary>
        [DataMember]
        public LanguagePreferences? LanguagePreference
        { 
            get; 
            set;
        }

        /// <summary>
        /// Allow or disable the use of HTML and graphics in customer emails.
        /// </summary>
        [DataMember]
        public bool? UseHtmlAndGraphics
        {
            get;
            set;
        }

        /// <summary>
        /// Utility method to determine whether any preferences have been changed in the inbound request.
        /// </summary>
        /// <returns>Whether any preferences have been set for the request.</returns>
        public bool Any()
        {
            return
                LanguagePreference.HasValue || UseHtmlAndGraphics.HasValue;
        }
    }
}
