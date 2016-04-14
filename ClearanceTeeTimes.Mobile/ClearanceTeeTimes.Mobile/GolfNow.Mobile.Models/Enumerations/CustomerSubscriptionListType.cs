using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.Enumerations
{
    /// <summary>
    /// Defines numeric types for subscribable lists.
    /// </summary>
    [DataContract]
    public enum CustomerSubscriptionListType
    {
        /// <summary>
        /// Instructs the API to retrieve all lists, regardless of type.
        /// </summary>
        [EnumMember]
        All = 0,

        /// <summary>
        /// Instructs the API to retrieve only those lists that are non-Hot Deal, non-course entries in the Customer Database table.
        /// </summary>
        [EnumMember]
        CustomerDatabase = 1,

        /// <summary>
        /// Instructs the API to retrieve only Hot Deals lists.
        /// </summary>
        [EnumMember]
        HotDeals = 2,

        /// <summary>
        /// Instructs the API to retrieve only DealCaddy lists.
        /// </summary>
        [EnumMember]
        DealCaddy = 3,

        /// <summary>
        /// Instructs the API to retrieve only course-specific lists.
        /// </summary>
        [EnumMember]
        Course = 4,
    }
}
