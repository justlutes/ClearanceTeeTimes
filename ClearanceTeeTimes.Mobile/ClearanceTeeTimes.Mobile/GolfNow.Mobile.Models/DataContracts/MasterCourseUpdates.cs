using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    [DataContract]
    public class MasterCourseUpdates
    {
        public MasterCourseUpdates()
        {
            Changes = new List<MasterCourseKeyValuePair>();
        }

        [DataMember]
        public List<MasterCourseKeyValuePair> Changes { get; set; }

        public Dictionary<string, object> ToDictionary()
        {
            Dictionary<string, object> changedProperties = new Dictionary<string, object>();

            foreach (MasterCourseKeyValuePair kvp in Changes)
            {
                changedProperties.Add(kvp.PropertyName, kvp.PropertyValue);
            }

            return changedProperties;
        }
    }

    [DataContract]
    public class MasterCourseKeyValuePair
    {
        [DataMember]
        public string PropertyName { get; set; }

        [DataMember]
        public object PropertyValue { get; set; }
    }
}
