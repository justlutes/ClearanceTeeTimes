using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Represents an affiliate payment that will be honored by the GolfNow system.  Affiliate payments are essentially an avenue
    /// for a trusted partner to reserve tee times on the GolfNow reservation platform without using the GolfNow payment 
    /// processing platform.
    /// </summary>
    [DataContract]
    public class AffiliatePayment : PaymentInfo
    {
        /// <summary>
        /// The date and time that the payment was processed on the affiliate's system.
        /// </summary>
        [IgnoreDataMember]
        public DateTime? PaymentTimeStamp
        {
            get;
            set;
        }

        /// <summary>
        /// The formatted time stamp, for serialization purposes
        /// </summary>
        [DataMember(Name = "PaymentTimeStamp")]
        private string PaymentTimeStampFormatted
        {
            get
            {
                if (PaymentTimeStamp.HasValue)
                {
                    return this.PaymentTimeStamp.Value.ToFormattedString();
                }
                else
                {
                    return null;
                }
            }
            set
            {
                DateTime? dt = value.ToDateTime();
                this.PaymentTimeStamp = dt;
            }
        }

        /// <summary>
        /// The amount of the payment that was processed on the affiliate's system.
        /// </summary>
        [DataMember]
        public decimal? PaymentAmount
        {
            get;
            set;
        }

        /// <summary>
        /// The reference number for the payment on the affiliate's system.
        /// </summary>
        [DataMember]
        public string PaymentRefrenceNumber
        {
            get;
            set;
        }

        /// <summary>
        /// OPTIONAL: The billing zip code of the credit card used by the customer to book a tee time.  This value is used to 
        /// verify the booking of a resident rate.  Because GolfNow doesn't take payment in an 'Affiliate Payment' scenario, the 
        /// affiliate must pass the billing zip code of the customer if the affiliate wants to support the booking of resident tee 
        /// time rates.  
        /// 
        /// This is to allow the booking of the tee time.  The golf course may still verify the residency status of the golfer 
        /// once the golfer checks in for the tee time.
        /// </summary>
        [DataMember]
        public string CustomerBillingZipCode { get; set; }
    }
}
