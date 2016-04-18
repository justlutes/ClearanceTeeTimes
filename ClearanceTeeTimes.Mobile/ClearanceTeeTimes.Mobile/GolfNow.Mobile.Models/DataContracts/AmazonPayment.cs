﻿using System;
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
    public class AmazonPayment : PaymentInfo
    {
        /// <summary>
        /// Gets or sets the Amazon order Id generated by Payment SDK.
        /// </summary>
        [DataMember(Name = "AmazonOrderReferenceID")]
        public string AmazonOrderReferenceID
        {
            get;
            set;
        }
        

        
    }
}