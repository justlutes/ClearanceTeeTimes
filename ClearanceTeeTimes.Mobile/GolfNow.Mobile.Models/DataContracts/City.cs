using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A data contract for Cities.
    /// </summary>
    [DataContract]
    public class City
    {
        /// <summary>
        /// Gets or sets the name of the city.
        /// </summary>
        [DataMember]
        public string CityName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the state provence code associated with the city.
        /// </summary>
        [DataMember]
        public string StateProvinceCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the country code associated with the city.
        /// </summary>
        [DataMember]
        public string CountryCode
        {
            get;
            set;
        }

        public override string ToString()
        {
            return this.CityName;
        }
    }
}
