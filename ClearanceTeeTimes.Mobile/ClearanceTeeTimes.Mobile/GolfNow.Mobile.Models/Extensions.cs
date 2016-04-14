using System;

//using GolfNow.API.Contracts.WebFaults;

namespace GolfNow.Mobile.Models
{
    //using System.ServiceModel.Web;

    internal static class Extensions
    {
        public static string ToFormattedString(this DateTime date)
        {
            return date.ToString("yyyy-MM-ddTHH:mm:ss");
        }

        public static DateTime? ToDateTime(this string date)
        {
            if (String.IsNullOrEmpty(date))
                return null;

            //see if string is json date
            if (date.Contains("Date("))
            {
                date = date.Substring(date.IndexOf("Date(") + 5);
                date = date.Substring(0, date.IndexOf(")"));

                if (date.Contains("-"))
                    date = date.Substring(0, date.IndexOf("-"));
                else if (date.Contains("+"))
                    date = date.Substring(0, date.IndexOf("+"));

                long uts;
                if (Int64.TryParse(date, out uts))
                {
                    DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0);
                    dt = dt.AddMilliseconds(uts);
                    return dt;
                }
            }


            //then try to parse as datetime
            DateTime d;
            if (DateTime.TryParse(date, out d))
            {
                return d;
            }
            return null;
        }

        //        public static T ConvertIntToEnum<T>(this int value, string PropertyName) where T : struct
        //        {
        //            if (Enum.IsDefined(typeof(T), value))
        //            {
        //                return (T)Enum.ToObject(typeof(T), value);
        //            }
        //            else
        //            {
        //                // TODO: Revert to previous version when a contract change occurs GAP-593 
        //                const string advancedErrorCodesHeaderText = "AdvancedErrorCodes";
        //                bool useAdvancedErrorCodes = false;

        //                if (WebOperationContext.Current != null &&
        //                    WebOperationContext.Current.IncomingRequest.Headers.AllKeys.Contains(advancedErrorCodesHeaderText))
        //                {
        //                    string advancedErrorCodesValue = WebOperationContext.Current.IncomingRequest.Headers[advancedErrorCodesHeaderText];

        //                    bool.TryParse(advancedErrorCodesValue, out useAdvancedErrorCodes);
        //                }

        //                if (useAdvancedErrorCodes)
        //                {
        //                    throw new SimpleWebFault("Invalid value for property " + PropertyName, ErrorCode.UnableToParseEnum);
        //                }

        //                throw new LegacyWebFault(
        //                    string.Format("Invalid value for property {0}", PropertyName), 
        //                    ErrorCode.UnableToParseEnum);

        //            }
        //        }

        //        /// <summary>
        //        /// Gets an attribute on an enum field value
        //        /// </summary>
        //        /// <typeparam name="T">The type of the attribute you want to retrieve</typeparam>
        //        /// <param name="enumVal">The enum value</param>
        //        /// <returns>The attribute of type T that exists on the enum value</returns>
        //        public static t Getattributeoftype<t>(this enum enumval) where t : system.attribute
        //        {
        //            var type = enumval.gettype();
        //            var meminfo = type.getmember(enumval.tostring());
        //            var attributes = meminfo[0].getcustomattributes(typeof(t), false);
        //            return (attributes.length > 0) ? (t)attributes[0] : null;
        //        }

        //        public static System.Net.HttpStatusCode GetHttpStatusCode(this ErrorCode input)
        //        {
        //            ErrorCodeAttribute attr = input.GetAttributeOfType<ErrorCodeAttribute>();
        //            if (attr == null)
        //            {
        //                return System.Net.HttpStatusCode.InternalServerError;
        //            }
        //            else
        //            {
        //                return attr.Code;
        //            }
        //        }

        //        public static int GetErrorCode(this ErrorCode input)
        //        {
        //            return (int)input;
    }
}
