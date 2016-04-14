using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using GolfNow.Mobile.Models.Enumerations;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A contract summarizing the current subscriptions and preferences for a customer.
    /// </summary>
    [DataContract]
    public class CustomerSubscriptionProfile
    {
        /// <summary>
        /// A list of subscriptions for the customer.
        /// </summary>
        [DataMember]
        public Subscription[] Subscriptions
        {
            get;
            set;
        }

        /// <summary>
        /// Whether or not the customer is subscribed to rewards emails. If null, the customer does not have a Rewards account set up.
        /// </summary>
        [DataMember]
        public bool? IsSubscribedToRewards
        {
            get;
            set;
        }

        /// <summary>
        /// Whether or not the customer is subscribed to partner emails.
        /// </summary>
        [DataMember]
        public bool? IsSubscribedToPartners
        {
            get;
            set;
        }

        [DataMember]
        public LanguagePreferences? LanguagePreference
        {
            get;
            set;
        }

        [DataMember]
        public bool? UseHtmlAndGraphics
        {
            get;
            set;
        }

        public bool Any()
        {
            return
                (Subscriptions != null && Subscriptions.Length > 0) ||
            IsSubscribedToRewards != null ||
            IsSubscribedToPartners != null ||
            LanguagePreference != null ||
            UseHtmlAndGraphics != null;
        }

        public CustomerSubscriptionProfile Clone()
        {
            return new CustomerSubscriptionProfile
            {
                Subscriptions = this.Subscriptions.Select(s =>
                                    new Subscription
                    {
                        Type = s.Type,
                        SubscriptionListID = s.SubscriptionListID,
                        ListName = s.ListName,
                        IsSubscribed = s.IsSubscribed,
                        IsPassive = s.IsPassive
                    }
                ).ToArray(),
                IsSubscribedToPartners = this.IsSubscribedToPartners,
                IsSubscribedToRewards = this.IsSubscribedToRewards,
                UseHtmlAndGraphics = this.UseHtmlAndGraphics,
                LanguagePreference = this.LanguagePreference
            };
        }

        public void FlipSubscriptions(bool? setValue = null)
        {
            foreach (var subscription in this.Subscriptions)
            {
                subscription.IsSubscribed 
                    = setValue.HasValue
                    ? setValue.Value
                    : !subscription.IsSubscribed;
            }
        }
    }
}
