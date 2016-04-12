using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// The result of the upload of verification documentation.  THIS DOES NOT REPRESENT WHETHER OR NOT THE CUSTOMER HAS BEEN
    /// SUCCESSFULLY VALIDATED.  This only let's the caller know that the upload of the documentation was successful.
    /// </summary>
    [DataContract]
    public class DocumentationReviewRequestResult
    {
        /// <summary>
        /// A value indicating whether or not the upload process was successful.
        /// </summary>
        [DataMember]
        public bool UploadSuccessful { get; set; }
    }
}