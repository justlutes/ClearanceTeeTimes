using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Specifies options for expanding the output of a query.
    /// </summary>
    [DataContract]
    [TypeConverter(typeof(ExpandOptionsConverted))]
    public class ExpandRequest
    {
        private List<ExpandSetting> _expandsettings = new List<ExpandSetting>();

        /// <summary>
        /// Gets a list of expand settings
        /// </summary>
        [DataMember]
        public List<ExpandSetting> ExpansionSettings
        {
            get
            {
                return _expandsettings;
            }
        }

        /// <summary>
        /// Creates a new instance of an ExpandRequest from the input string representation that is delimited by the pipe character.
        /// </summary>
        public static ExpandRequest Parse(string value)
        {
            ExpandRequest options = new ExpandRequest();

            if (!string.IsNullOrWhiteSpace(value))
            {
                string[] splits = value.Split(new char[] {';', '|'}, StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in splits)
                {
                    options.ExpansionSettings.Add(ExpandSetting.Parse(s));
                }
            }
            return options;
        }

        /// <summary>
        /// Converts the ExpandRequest into it's string representation by joining the Expansion settings with a Pipe.
        /// </summary>
        public override string ToString()
        {
            return string.Join("|", this.ExpansionSettings);
        }

        /// <summary>
        /// Returns true if any of the expansion settings math the specified expansion path.
        /// </summary>
        public bool MatchesPath(string name)
        {
            return ExpansionSettings.Count(a => a.ExpandPath == name) > 0;
        }

        /// <summary>
        /// Provides conversion for ExpandRequest to and from a string for use by the WCF query string parser.
        /// </summary>
        public class ExpandOptionsConverted : TypeConverter
        {
            public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
                return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
            }
            public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
            {
                if (value is string || value == null)
                {
                    return ExpandRequest.Parse((string)value);
                }
                else
                {
                    return base.ConvertFrom(context, culture, value);
                }
            }
            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
            {
                return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
            }
            public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
            {
                if (destinationType == typeof(string) && value is ExpandRequest)
                {
                    return (value as ExpandRequest).ToString();
                }
                return base.ConvertTo(context, culture, value, destinationType);
            }
        }
    }

}
