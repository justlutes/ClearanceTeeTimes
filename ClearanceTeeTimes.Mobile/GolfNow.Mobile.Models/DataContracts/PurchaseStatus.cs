using System;
using System.Globalization;
using System.Runtime.Serialization;

using GolfNow.API.Contracts.WebFaults;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Represents the purchase status of a specific product distributed by a specific channel to a customer.
    /// </summary>
    [DataContract]
    public class PurchaseStatus
    {
        private static readonly string[] AcceptedDateTimeFormats =
        {
            // ISO 8601 'basic' format
            "yyyyMMddTHHmm",

            // .NET 'sortable' format (this is the legacy format)
            "s"
        };

        [DataMember(Name = "ExpirationDate")]
        private string _expirationDate;
        /// <summary>
        /// The expiration date in the 'basic' ISO 8601 format.  This date/time is in UTC.
        /// </summary>
        /// <remarks>
        /// The date/time format for this property is not consistent with the date/time format of the remainder of the API.
        /// 
        /// The expiration date uses the 'basic' ISO 8601 format.  Using 5/21/2014 @ 1:30 PM as an example, this format
        /// would be encoded as 20140521T1330.
        /// </remarks>
        public DateTime ExpirationDate
        {
            get
            {
                try
                {
                    return DateTime.ParseExact(
                        _expirationDate,
                        AcceptedDateTimeFormats,
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.AssumeLocal);
                }
                catch (FormatException)
                {
                    Raise.RaiseNow(ErrorCode.UnableToParseDate, "ExpirationDate is not in the correct format.");

                    throw;
                }
            }
            set
            {
                _expirationDate = value.ToString("yyyyMMddTHHmm");
            }
        }

        public override bool Equals(object obj)
        {
            var purchaseStatus = obj as PurchaseStatus;
            
            if (purchaseStatus == null)
            {
                return false;
            }

            return ExpirationDate.Equals(purchaseStatus.ExpirationDate);
        }

        public override int GetHashCode()
        {
            return ExpirationDate.GetHashCode();
        }
    }
}