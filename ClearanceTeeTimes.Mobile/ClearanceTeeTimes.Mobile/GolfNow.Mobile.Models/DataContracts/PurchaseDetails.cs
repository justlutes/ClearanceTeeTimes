using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

using GolfNow.Mobile.Models.WebFaults;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Represents the details of a purchase a client desires to add to a customer's account.
    /// </summary>
    [DataContract]
    public class PurchaseDetails
    {
        private static readonly string[] AcceptedDateTimeFormats =
            {
                // ISO 8601 'basic' format
                "yyyyMMddTHHmm",

                // .NET 'sortable' format (this is the legacy format)
                "s"
            };

        /// <summary>
        /// The distribution channel identifier.
        /// </summary>
        [DataMember]
        public int ChannelID { get; set; }

        [DataMember(Name = "ExpirationDate")]
        private string _expirationDate;

        /// <summary>
        /// Optional value that, when used in a POST body, allows the client to set the expiration date of the purchase.  In the
        /// DEV environment, the date can be set to a time in the past.  If not set, a default of 1 year after the expiration of 
        /// the previous purchase or 1 year after the purchase date, whichever is later, is used.  The date/time is UTC.
        /// </summary>
        /// <remarks>
        /// The date/time format for this property is not consistent with the date/time format of the remainder of the API.
        /// 
        /// The expiration date uses the 'basic' ISO 8601 format.  Using 5/21/2014 @ 1:30 PM as an example, this format
        /// would be encoded as 20140521T1330.
        /// </remarks>
        public DateTime? ExpirationDate
        {
            get
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(_expirationDate))
                    {
                        return null;
                    }

                    return DateTime.ParseExact(
                        _expirationDate,
                        AcceptedDateTimeFormats,
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.AssumeLocal);
                }
                catch (FormatException)
                {
                    //TODO:Catch exception
                    //                    Raise.RaiseNow(ErrorCode.UnableToParseDate, "ExpirationDate is not in the correct format.");
                    //
                    throw;
                }
            }
            set
            {
                _expirationDate = value == null ? null : value.Value.ToString("yyyyMMddTHHmm");
            }
        }

        /// <summary>
        /// The purchase data.  This can be used to store a purchase receipt.
        /// </summary>
        [DataMember]
        public string PurchaseData { get; set; }

        [DataMember(Name = "PurchaseDate")]
        private string _purchaseDate;

        /// <summary>
        /// The purchase date in the 'basic' ISO 8601 format.  This date/time is in UTC.
        /// </summary>
        /// <remarks>
        /// The date/time format for this property is not consistent with the date/time format of the remainder of the API.
        /// 
        /// The purchase date uses the 'basic' ISO 8601 format.  Using 5/21/2014 @ 1:30 PM as an example, this format
        /// would be encoded as 20140521T1330.
        /// </remarks>
        public DateTime PurchaseDate
        {
            get
            {
                try
                {
                    return DateTime.ParseExact(
                        _purchaseDate,
                        AcceptedDateTimeFormats,
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.AssumeLocal);
                }
                catch (FormatException)
                {
                    //TODO:Catch exception
                    //                    Raise.RaiseNow(ErrorCode.InvalidPurchaseDateSpecified, "PurchaseDate is not in the correct format.");
                    //
                    throw;
                }
            }
            set
            {
                _purchaseDate = value.ToString("yyyyMMddTHHmm");
            }
        }

        /// <summary>
        /// Information about a promo code to be sent to the user in response for making the purchase.  If no promo code is to be
        /// sent, this should be left empty.
        /// </summary>
        [DataMember]
        public PromoCodeInfo PromoCodeInfo { get; set; }

        /// <summary>
        /// The identifier of the product.
        /// </summary>
        [DataMember]
        public string ProductID { get; set; }
    }
}
