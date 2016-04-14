using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    [DataContract]
    public class FacilityDetail : Facility
    {
        /// <summary>
        /// Gets or sets the description of the facility.
        /// </summary>
        [DataMember]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the address of the facility.
        /// </summary>
        [DataMember]
        public Address Address
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the facility's currency code.  Deprecated.
        /// </summary>
        [DataMember]
        [Obsolete("This property has been deprecated.  The currency code should be passed along with tee times.")]
        public string CurrencyCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets information about the facility.
        /// </summary>
        [DataMember]
        public string Information
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the facility's thumbnail image path.
        /// </summary>
        [DataMember]
        public string ThumbnailImagePath
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a list of tags associated with the facility.  For instance: PTP or PMP
        /// </summary>
        [DataMember]
        public string[] Tags
        {
            get;
            set;
        }

        /// <summary>
        /// The phone number for the facility.
        /// </summary>
        [DataMember]
        public string PhoneNumber
        {
            get;
            set;
        }

        /// <summary>
        /// The email address for the facility.
        /// </summary>
        [DataMember]
        public string EmailAddress
        {
            get;
            set;
        }

        /// <summary>
        /// The website address for the facility.
        /// </summary>
        [DataMember]
        public string WebsiteAddress
        {
            get;
            set;
        }

        /// <summary>
        /// The facility's tee time policy.
        /// </summary>
        [DataMember]
        public string TeeTimePolicy { get; set; }

        public override string ToString()
        {
            return string.Format("{0} | {1}", this.ID, this.Name);
        }

        /// <summary>
        /// The time zone offset of the facility.
        /// </summary>
        [DataMember]
        public decimal TimeZoneOffset { get; set; }

        /// <summary>
        /// A value indicating whether this facility is active.
        /// </summary>
        [DataMember]
        public bool IsActive { get; set; }

        /// <summary>
        /// A value indicating whether this facility has multiple golf courses.
        /// </summary>
        [DataMember]
        public bool IsMultiCourse { get; set; }
    }
}