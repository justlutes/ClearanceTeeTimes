using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A data contract for Rate tags.
    /// </summary>
    [DataContract]
    public class RateTag
    {
        /// <summary>
        /// Gets or sets rate tag description.
        /// </summary>
        [DataMember]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets rate tag image uri.
        /// </summary>
        [DataMember]
        public string ImageUri
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets rate tag code
        /// </summary>
        [DataMember]
        public string Code
        {
            get;
            set;
        }

        /// <summary>
        /// Get or sets rate tag name
        /// </summary>
        [DataMember]
        public string Title 
        {
            get;
            set;
        }
    }
}
