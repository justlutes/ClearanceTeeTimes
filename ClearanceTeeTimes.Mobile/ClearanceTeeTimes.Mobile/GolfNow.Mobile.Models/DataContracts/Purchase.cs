namespace GolfNow.Mobile.Models.DataContracts
{
    using System;
    using System.Globalization;
    using System.Runtime.Serialization;

    //    using GolfNow.API.Contracts.WebFaults;

    /// <summary>
    /// Represents purchase data supplied by the client.
    /// </summary>
    [DataContract]
    public class Purchase
    {
        private static readonly string[] AcceptedDateTimeFormats =
            {
                // ISO 8601 'basic' format
                "yyyyMMddTHHmm",

                // .NET 'sortable' format (this is the legacy format)
                "s"
            };

        /// <summary>
        /// The customer email address.
        /// </summary>
        [DataMember]
        public string CustomerEmailAddress { get; set; }

        /// <summary>
        /// The detailed purchase information. (e.g., receipt data).  This value should be URL encoded to ensure successful 
        /// transmission.
        /// </summary>
        [DataMember]
        public string PurchaseInfo { get; set; }

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
//                    Raise.RaiseNow(ErrorCode.InvalidPurchaseDateSpecified, "PurchaseDate is not in the correct format.");

                    throw;
                }
            }
            set
            {
                _purchaseDate = value.ToString("yyyyMMddTHHmm");
            }
        }

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
//                    Raise.RaiseNow(ErrorCode.UnableToParseDate, "ExpirationDate is not in the correct format.");

                    throw;
                }
            }
            set
            {
                _expirationDate = value == null ? null : value.Value.ToString("yyyyMMddTHHmm");
            }
        }

        /// <summary>
        /// Optional value that, when used in a POST body, allows the client to specify detailed information about a promo code
        /// that should be sent to the customer upon successful completion of a purchase.  This property is not returned when 
        /// getting purchase information.
        /// </summary>
        [DataMember]
        public PromoCodeInfo PromoCodeInfo { get; set; }

        /// <summary>
        /// An optional GolfNow supplied GUID that identifies a specific type of purchase.  When used, this value will 
        /// differentiate one type of 
        /// purchase from another.
        /// </summary>
        [DataMember]
        public string ProductID { get; set; }
    }
}