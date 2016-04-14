using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A data contract for Countries.
    /// </summary>
    [DataContract]
    public class Country
    {
        /// <summary>
        /// Gets or sets the name of the country.
        /// </summary>
        [DataMember]
        public string CountryName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        [DataMember]
        public string CountryCode
        {
            get;
            set;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}", this.CountryCode, this.CountryName);
        }
    }
}
