using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A summary object detailing subscribable mailing lists and information about the list.
    /// </summary>
    [DataContract]
    public class Subscription
    {
        /// <summary>
        /// The type of subscription - one of "GolfNow" (for Hot Deal related mailers), "DealCaddy" (for Deal Caddy mailing lists),
        /// "Course" (for course-specific mailing lists), or "Customer Database" (for non-Hot Deals, non-course related mailing lists).
        /// </summary>
        [DataMember]
        public string Type
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the list itself. For Hot Deals and Deal Caddy type lists, this usually relays the target market for the mailing list 
        /// (e.g.: "Orlando", "Los Angeles"). For courses, this is generally the course name. For other types of lists, it is the list name as
        /// entered in the database.
        /// </summary>
        [DataMember]
        [XSSIntrusionPreventionIgnore]
        public string ListName
        {
            get;
            set;
        }

        /// <summary>
        /// The internal ID of the subscription list. If the string is numeric, it represents a GolfNow Hot Deals mailing list. If it
        /// begins with the characters "DC_", it is a Deal Caddy-related mailing list.
        /// </summary>
        [DataMember]
        public string SubscriptionListID
        {
            get;
            set;
        }

        /// <summary>
        /// Whether or not the customer is currently subscribed to the list.
        /// </summary>
        [DataMember]
        public bool IsSubscribed
        {
            get;
            set;
        }

        /// <summary>
        /// DEPRECATED. Specifies whether or not the UI can automatically check the box for the customer to subscribe to this mailing
        /// list during checkout. For Canadian customers, this field is always set to "0" (in compliance with the Canadian Anti-Spam
        /// Law). Please ensure you are complying with local, state, and federal law, as well as with your business's policy on
        /// automatic subscriptions of customers to mailing lists, before leveraging this field.
        /// </summary>
        [DataMember]
        public string IsPassive
        {
            get;
            set;
        }
    }
}
