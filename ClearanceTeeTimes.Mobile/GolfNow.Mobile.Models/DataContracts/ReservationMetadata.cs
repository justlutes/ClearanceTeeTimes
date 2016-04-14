using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

using GolfNow.API.Contracts.Enumerations;

namespace GolfNow.Mobile.Models.DataContracts
{
    [DataContract]
    public class ReservationMetadata
    {
        [DataMember]
        public ReservationMetadataType Key { get; set; }

        [DataMember]
        public string Value { get; set; }
    }
}
