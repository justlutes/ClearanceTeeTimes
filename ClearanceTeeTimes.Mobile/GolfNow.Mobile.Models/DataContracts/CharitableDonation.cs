using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Represents an amount donated to a specific charity.
    /// </summary>
    [DataContract]
    public class CharitableDonation
    {
        /// <summary>
        /// The identifier of the charity.
        /// </summary>
        [DataMember]
        public int CharityID { get; set; }

        /// <summary>
        /// The amount to be donated..
        /// </summary>
        [DataMember]
        public decimal DonationAmount { get; set; }
    }
}
