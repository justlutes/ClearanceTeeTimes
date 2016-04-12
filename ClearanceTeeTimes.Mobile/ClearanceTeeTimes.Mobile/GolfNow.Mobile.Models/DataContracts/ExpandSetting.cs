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
    /// Represents a request for property expansion for the class path specified by ExpandPath.
    /// </summary>
    public class ExpandSetting
    {
        /// <summary>
        /// The path from the root the the expandable property.
        /// </summary>
        public string ExpandPath
        {
            get;
            set;
        }

        /// <summary>
        /// Creates a new instance of an ExpandSetting from the input string representation that is delimited by the pipe character.
        /// </summary>
        public static ExpandSetting Parse(string value)
        {
            return new ExpandSetting()
            {
                ExpandPath = value
            };
        }

        /// <summary>
        /// Converts the ExpandSetting into it's string representation.
        /// </summary>
        public override string ToString()
        {
            return ExpandPath;
        }

        /// <summary>
        /// Provides for implicit conversion from a valid ExpandSetting string into ExpandSetting object.
        /// </summary>
        public static implicit operator ExpandSetting(string input)
        {
            return ExpandSetting.Parse(input);
        }
    }
}
