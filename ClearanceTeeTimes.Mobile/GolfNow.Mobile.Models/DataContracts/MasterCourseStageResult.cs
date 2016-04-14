using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    [DataContract]
    public class MasterCourseStageResult
    {
        [DataMember]
        public bool Okay { get; set; }

        [DataMember]
        public string Message { get; set; }
    }
}
