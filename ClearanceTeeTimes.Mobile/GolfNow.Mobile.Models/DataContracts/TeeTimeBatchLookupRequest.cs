using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A contract that specifies a number of tee time IDs to look up.
    /// </summary>
    [DataContract]
    public class TeeTimeBatchLookupRequest
    {
        /// <summary>
        /// The list of IDs to consult.
        /// </summary>
        [DataMember]
        public List<string> Ids
        {
            get;
            set;
        }
    }
}
