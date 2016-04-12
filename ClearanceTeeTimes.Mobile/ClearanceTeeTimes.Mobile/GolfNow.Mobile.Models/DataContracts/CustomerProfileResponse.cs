using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A data contract for a customer profile including output-only, server generated information.
    /// </summary>
    [DataContract]
    public class CustomerProfileResponse : CustomerProfile
    {
        /// <summary>
        /// Gets or sets the globally unique identifier for the customer.
        /// </summary>
        [DataMember]
        public string CustomerGuid
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the status of the customer's loyalty account when expanded.
        /// </summary>
        [DataMember(EmitDefaultValue=false)]
        public Expandable<LoyaltyStatus> LoyaltyStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets any saved payment information for the customer.
        /// </summary>
        [DataMember]
        public SavedPaymentInfo[] SavedPaymentMethods
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this customer's email has been verified.
        /// </summary>
        /// <value>
        /// <c>true</c> if this this customer's email has been verified; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool IsEmailVerified
        {
            get; 
            set;
        }
    }
}
