using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    [DataContract]
    public class ValidateTokenRequest
    {
        [DataMember]
        [XSSIntrusionPreventionIgnore]
        public string Token { get; set; }
    }
}
