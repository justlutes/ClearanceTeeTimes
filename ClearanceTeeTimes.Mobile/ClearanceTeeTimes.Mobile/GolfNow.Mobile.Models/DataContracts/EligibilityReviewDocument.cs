using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A document supplied by the golfer that is to be used to verify eligibility.
    /// </summary>
    [DataContract]
    public class EligibilityReviewDocument
    {
        /// <summary>
        /// REQUIRED: The array of bytes that represent the contents of the review document.
        /// </summary>
        [DataMember]
        public byte[] Content { get; set; }

        /// <summary>
        /// REQUIRED: The name of the review document file.  The name must include the name and the extension but not the path.  
        /// The supported file types are bmp, doc, docx, gif, jp2, jpeg, jpg, pdf, png, rtf, tif, tiff, txt, xls, xlsx, and xps.
        /// </summary>
        [DataMember]
        public string FileName { get; set; }
    }
}