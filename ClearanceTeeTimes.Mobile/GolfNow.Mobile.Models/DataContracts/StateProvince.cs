using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A data contract for StateProvinces.
    /// </summary>
    [DataContract]
    public class StateProvince
    {
        /// <summary>
        /// Gets or sets the name of the state/province.
        /// </summary>
        [DataMember]
        public string StateProvinceName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the state/province code.
        /// </summary>
        [DataMember]
        public string StateProvinceCode
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
            return string.Format("{0} : {1}", this.StateProvinceCode, this.StateProvinceName);
        }
    }
}
