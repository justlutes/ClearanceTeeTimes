using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    [DataContract]
    //[TypeConverter(typeof(MasterCourseCompositeLookupConverted))]
    public class MasterCourseCompositeLookup
    {
        [DataMember]
        public string SourceSystemID { get; set; }

        [DataMember]
        public string CourseID { get; set; }

        public override string ToString()
        {
            return "SSID:" + SourceSystemID.ToString() + ";" +
            "CID:" + CourseID.ToString();
        }

        public static MasterCourseCompositeLookup Parse(string value)
        {
            MasterCourseCompositeLookup lookup = new MasterCourseCompositeLookup()
            {
                SourceSystemID = "",
                CourseID = ""
            };

            string[] values = value.Split(';');
            // int parsingValue;

            foreach (string parseable in values)
            {
                string[] parsed = parseable.Split(':');

                if (parsed.Length == 2)
                {
                    switch (parsed[0])
                    {
                        case "SSID":
                            lookup.SourceSystemID = parsed[1];
                            break;
                        case "CID":
                            lookup.CourseID = parsed[1];
                            break;
                    }
                }
            }

            return lookup;
        }
    }

    public class MasterCourseCompositeLookupConverted //: TypeConverter
    {
        //public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        //{
        //    return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
        //}

        //public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        //{
        //    if (value is string || value != null)
        //    {
        //        return MasterCourseCompositeLookup.Parse((string)value);
        //    }
        //    else
        //    {
        //        return base.ConvertFrom(context, culture, value);
        //    }
        //}

        //public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        //{
        //    return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
        //}

        //public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        //{
        //    if (destinationType == typeof(string) && value is MasterCourseCompositeLookup)
        //    {
        //        return (value as MasterCourseCompositeLookup).ToString();
        //    }
        //    return base.ConvertTo(context, culture, value, destinationType);
        //}
    }
}
