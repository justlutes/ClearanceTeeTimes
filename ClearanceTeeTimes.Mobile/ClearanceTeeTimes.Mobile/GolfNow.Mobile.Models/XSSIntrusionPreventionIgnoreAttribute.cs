using System;

namespace GolfNow.Mobile.Core.Models
{
    /// <summary>
    /// When added to a property of a data contract, the XSS intrusion inspector will ignore the property.
    /// </summary>
    public sealed class XSSIntrusionPreventionIgnoreAttribute : Attribute
    {
        public XSSIntrusionPreventionIgnoreAttribute()
        {
            //NO OP
        }
    }
}
