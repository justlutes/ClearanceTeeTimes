using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Provides geographic data about a particular location.
    /// </summary>
    [DataContract]
    public class GeographicInformation
    {
        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        [DataMember]
        public string PostalCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the city name.
        /// </summary>
        [DataMember]
        public string CityName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a state/province code.
        /// </summary>
        [DataMember]
        public string StateProvinceCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets an area code.
        /// </summary>
        [DataMember]
        public string AreaCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        [DataMember]
        public string County
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the geographic latitude.
        /// </summary>
        [DataMember]
        public decimal? Latitude
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the geographic longitude.
        /// </summary>
        [DataMember]
        public decimal? Longitude
        {
            get;
            set;
        }
    }
}
