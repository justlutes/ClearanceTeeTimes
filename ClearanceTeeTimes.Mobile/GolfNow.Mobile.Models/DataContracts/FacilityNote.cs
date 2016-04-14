using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A single entry of the customer facility notes.
    /// </summary>
    [DataContract]
    public class FacilityNote
    {
        /// <summary>
        /// The golf facility identifier.
        /// </summary>
        [DataMember]
        public int GolfFacilityID { get; set; }

        /// <summary>
        /// The note.
        /// </summary>
        [DataMember]
        public string Note { get; set; }
    }
}
