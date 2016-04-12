using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Describes a market area which is used to group facilities geographically.
    /// </summary>
    [DataContract]
    public class Market
    {
        /// <summary>
        /// Gets or sets the market id.
        /// </summary>
        [DataMember]
        public int MarketID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the market.
        /// </summary>
        [DataMember]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a description of the market.
        /// </summary>
        [DataMember]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a country code for this market.
        /// </summary>
        [DataMember]
        public string CountryCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a state/province code for this market.
        /// </summary>
        [DataMember]
        public string StateProvinceCode
        {
            get;
            set;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", MarketID, Name);
        }
    }
}
