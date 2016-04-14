using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Represents a charity that a golfer can donate to at the time of reservation.
    /// </summary>
    [DataContract]
    public class Charity
    {
        /// <summary>
        /// The charity identifier.
        /// </summary>
        [DataMember]
        public int CharityID { get; set; }

        /// <summary>
        /// The name of the charity.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// The suggested contribution amounts.
        /// </summary>
        [DataMember]
        public decimal[] SuggestedContributionAmounts { get; set; }

        /// <summary>
        /// The description of the charity.
        /// </summary>
        [DataMember]
        public string Description { get; set; }
    }
}
