using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using GolfNow.Mobile.Core.Models;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Contains information necessary to process the customer's forgot password email request
    /// </summary>
    [DataContract]
    public class SendForgotPasswordEmailRequest
    {
        /// <summary>
        /// Gets or sets the url that takes the customer to the forgot my password page.
        /// </summary>
        [DataMember]
        [XSSIntrusionPreventionIgnore]
        public string ForgotPasswordUrl { get; set; }

        /// <summary>
        /// Gets or sets the url that takes the customer to the reset my password page.
        /// </summary>
        [DataMember]
        [XSSIntrusionPreventionIgnore]
        public string ResetPasswordUrl { get; set; }

        /// <summary>
        /// Gets or sets the url that takes the customer to the login page.
        /// </summary>
        [DataMember]
        [XSSIntrusionPreventionIgnore]
        public string LoginUrl { get; set; }

        /// <summary>
        /// Gets or sets the image url to use in the forgot password email header the customer receives.
        /// The image size must have the following dimensions: 542W x 120H and the image format must be either JPG or GIF.
        /// </summary>
        [DataMember]
        [XSSIntrusionPreventionIgnore]
        public string EmailHeaderImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the image url to use in the forgot password email footer the customer receives.
        /// The image size must have the following dimensions: 542W x 50H and the image format must be either JPG or GIF.
        /// </summary>
        [DataMember]
        [XSSIntrusionPreventionIgnore]
        public string EmailFooterImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the text to use in the forgot password email the customer receives.
        /// The text is limited to 255 characters and cannot contain HTML.
        /// </summary>
        [DataMember]
        public string EmailBodyText { get; set; }
    }
}
