//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
////using System.ServiceModel.Web;
//using System.Text;
//using System.Threading.Tasks;

//namespace GolfNow.API.Contracts.WebFaults
//{
//    /// <summary>
//    /// A helper class to raise faults based on input parameter constraints.
//    /// </summary>
//    public static class Raise
//    {
//        /// <summary>
//        /// Raises fault if 'o' is null.
//        /// </summary>
//        /// <param name="o">An object to inspect.</param>
//        /// <param name="message">The fault message on failure.</param>
//        /// <param name="args">Optional arguments to be string.formatted into the message.</param>
//        public static void IfNull(object o, ErrorCode code, string message, params object[] args)
//        {
//            if (o == null)
//            {
//                throw new Exception(code + message + args);
//            }
//        }

//        /// <summary>
//        /// Raises fault if 's' is null or white space.
//        /// </summary>
//        /// <param name="s">A string to inspect.</param>
//        /// <param name="message">The fault message on failure.</param>
//        /// <param name="args">Optional arguments to be string.formatted into the message.</param>
//        public static void IfNullOrWhitespace(string s, ErrorCode code, string message, params object[] args)
//        {
//            if (string.IsNullOrWhiteSpace(s))
//            {
//                throw CreateFault(code, message, args);
//            }
//        }

//        /// <summary>
//        /// Raises fault if 'a' is not equal to 'b' using InvariantCultureIgnoreCase comparison.
//        /// </summary>
//        /// <param name="a">A string to inspect.</param>
//        /// <param name="b">A second string to inspect.</param>
//        /// <param name="message">The fault message on failure.</param>
//        /// <param name="args">Optional arguments to be string.formatted into the message.</param>
//        public static void IfNotEqual(string a, string b, ErrorCode code, string message, params object[] args)
//        {
//            if (!string.Equals(a, b, StringComparison.InvariantCultureIgnoreCase))
//            {
//                throw CreateFault(code, message, args);
//            }
//        }

//        /// <summary>
//        /// Raises fault if the input string is not convertible to an integer.
//        /// </summary>
//        /// <param name="input">A string to convert to an integer.</param>
//        /// <param name="allownulls">A value indicating whether or not to allow null or empty strings in the input.</param>
//        /// <param name="positiveonly">A value indicating whether or not to constrain valid values to positive numbers only.</param>
//        /// <param name="message">The fault message on failure.</param>
//        /// <param name="args">Optional arguments to be formatted into the message.</param>
//        public static int? ConvertToInteger(string input, bool allownulls, bool positiveonly, ErrorCode code, string message, params object[] args)
//        {
//            if (string.IsNullOrWhiteSpace(input))
//            {
//                if (!allownulls)
//                {
//                    throw CreateFault(code, message, args);
//                }
//                else
//                {
//                    return null;
//                }
//            }
//            else
//            {
//                int i = 0;
//                if (!int.TryParse(input, out i) || (positiveonly && i <= 0))
//                {
//                    throw CreateFault(code, message, args);
//                }
//                else
//                {
//                    return i;
//                }
//            }
//        }

//        /// <summary>
//        /// Raises fault if the input string is not convertible to a boolean.
//        /// </summary>
//        /// <param name="input">A string to convert to a boolean value.</param>
//        /// <param name="allownulls">A value indicating whether or not to allow null or empty strings in the input.</param>
//        /// <param name="message">The fault message on failure.</param>
//        /// <param name="args">Optional arguments to be formatted into the message.</param>
//        public static bool? ConvertToBoolean(string input, bool allownulls, ErrorCode code, string message, params object[] args)
//        {
//            if (string.IsNullOrWhiteSpace(input))
//            {
//                if (!allownulls)
//                {
//                    throw CreateFault(code, message, args);
//                }
//                else
//                {
//                    return null;
//                }
//            }
//            else
//            {
//                bool b = false;
//                if (!bool.TryParse(input, out b))
//                {
//                    throw CreateFault(code, message, args);
//                }
//                else
//                {
//                    return b;
//                }
//            }
//        }

//        /// <summary>
//        /// Raises fault if the input string is null, not convertible to an integer, or a non-positive integer.
//        /// </summary>
//        /// <param name="input">A string to convert to an integer.</param>
//        /// <param name="message">The fault message on failure.</param>
//        /// <param name="args">Optional arguments to be string.formatted into the message.</param>
//        public static int ConvertToIdentityInteger(string input, ErrorCode code, string message, params object[] args)
//        {
//            return Raise.ConvertToInteger(input, false, true, code, message, args).Value;
//        }

//        /// <summary>
//        /// Raises fault if the input string is not a valid date time.
//        /// </summary>
//        /// <param name="input">A string to convert.</param>
//        /// <param name="allownulls">Throws fault if the input is null or whitespace.</param>
//        /// <param name="message">The fault message on failure.</param>
//        /// <param name="args">Optional arguments to be string.formatted into the message.</param>
//        public static DateTime? ConvertToDateTime(string input, bool allownulls, ErrorCode code, string message, params object[] args)
//        {
//            if (string.IsNullOrWhiteSpace(input))
//            {
//                if (!allownulls)
//                {
//                    throw CreateFault(code, message, args);
//                }
//                else
//                {
//                    return null;
//                }
//            }
//            else
//            {
//                DateTime t;
//                if (!DateTime.TryParse(input, out t))
//                {
//                    throw CreateFault(code, message, args);
//                }
//                else
//                {
//                    return t;
//                }
//            }
//        }

//        /// <summary>
//        /// Raises fault if the input string is not a valid date time or it is null/empty.
//        /// </summary>
//        /// <param name="input">A string to convert.</param>
//        /// <param name="message">The fault message on failure.</param>
//        /// <param name="args">Optional arguments to be string.formatted into the message.</param>
//        public static DateTime ConvertToDateTime(string input, ErrorCode code, string message, params object[] args)
//        {
//            DateTime? d = Raise.ConvertToDateTime(input, false, code, message, args);
//            return d.Value;
//        }

//        /// <summary>
//        /// Raises fault if the input string is not convertible to a decimal.
//        /// </summary>
//        /// <param name="input">A string to convert to a decimal.</param>
//        /// <param name="allownulls">A value indicating whether or not to allow null or empty strings in the input.</param>
//        /// <param name="message">The fault message on failure.</param>
//        /// <param name="args">Optional arguments to be formatted into the message.</param>
//        public static decimal? ConvertToDecimal(string input, bool allownulls, ErrorCode code, string message, params object[] args)
//        {
//            if (string.IsNullOrWhiteSpace(input))
//            {
//                if (!allownulls)
//                {
//                    throw CreateFault(code, message, args);
//                }
//                else
//                {
//                    return null;
//                }
//            }
//            else
//            {
//                decimal d = 0;
//                if (!decimal.TryParse(input, out d))
//                {
//                    throw CreateFault(code, message, args);
//                }
//                else
//                {
//                    return d;
//                }
//            }
//        }

//        /// <summary>
//        /// Raises fault if the input string is not convertible to a timespan.
//        /// </summary>
//        /// <param name="input">A string to convert to a timespan.</param>
//        /// <param name="allownulls">A value indicating whether or not to allow null or empty strings in the input.</param>
//        /// <param name="message">The fault message on failure.</param>
//        /// <param name="args">Optional arguments to be formatted into the message.</param>
//        public static TimeSpan? ConvertToTimeSpan(string input, bool allownulls, ErrorCode code, string message, params object[] args)
//        {
//            if (string.IsNullOrWhiteSpace(input))
//            {
//                if (!allownulls)
//                {
//                    throw CreateFault(code, message, args);
//                }
//                else
//                {
//                    return null;
//                }
//            }
//            else
//            {
//                TimeSpan ts;
//                if (!TimeSpan.TryParse(input, out ts))
//                {
//                    throw CreateFault(code, message, args);
//                }
//                else
//                {
//                    return ts;
//                }
//            }
//        }

//        /// <summary>
//        /// Raises fault if the input evaluates to true.
//        /// </summary>
//        /// <param name="input">A boolean expression to evaluate.</param>
//        /// <param name="message">The fault message.</param>
//        /// <param name="args">Optional arguments to be string.formatted into the message.</param>
//        public static void IfTrue(bool input, ErrorCode code, string message, params object[] args)
//        {
//            if (input)
//            {
//                throw CreateFault(code, message, args);
//            }
//        }

//        /// <summary>
//        /// Raises fault if the input evaluates to false.
//        /// </summary>
//        /// <param name="input">A boolean expression to evaluate.</param>
//        /// <param name="message">The fault message.</param>
//        /// <param name="args">Optional arguments to be string.formatted into the message.</param>
//        public static void IfFalse(bool input, ErrorCode code, string message, params object[] args)
//        {
//            if (!input)
//            {
//                throw CreateFault(code, message, args);
//            }
//        }

//        /// <summary>
//        /// Raises a fault if the specified data value is determined to be invalid.
//        /// </summary>
//        /// <param name="dateTime">The date time.</param>
//        /// <param name="code">The error code.</param>
//        /// <param name="message">A fault message.</param>
//        /// <param name="args">Optional arguments to be string.formatted into the message.</param>
//        public static void IfInvalid(DateTime dateTime, ErrorCode code, string message, params object[] args)
//        {
//            if (dateTime < DateTime.Parse("1753-1-1") || dateTime > DateTime.Parse("9999-12-31 23:59:59"))
//            {
//                throw CreateFault(code, message, args);
//            }
//        }

//        /// <summary>
//        /// Raises a fault unconditionally.
//        /// </summary>
//        /// <param name="message">The fault message.</param>
//        /// <param name="args">Optional arguments to be string.formatted into the message.</param>
//        public static void RaiseNow(ErrorCode code, string message, params object[] args)
//        {
//            throw CreateFault(code, message, args);
//        }

//        /// <summary>
//        /// Raises a fault if the input string length exceeds the maxLength provided.
//        /// </summary>
//        /// <param name="input">The string to have its length checked.</param>
//        /// <param name="maxLength">The length the input string should not exceed.</param>
//        /// <param name="message">The fault message on failure.</param>
//        /// <param name="args">Optional arguments to be string.formatted into the message.</param>
//        public static void IfExceedsMaxLength(string input, int maxLength, ErrorCode code, string message, params object[] args)
//        {
//            if (!string.IsNullOrWhiteSpace(input) && input.Length > maxLength)
//            {
//                throw CreateFault(code, message, args);
//            }
//        }

//        /// <summary>
//        /// Creates a fault with the specified message.
//        /// </summary>
//        /// <param name="errorCode">A detailed error code.</param>
//        /// <param name="message">The fault message on failure.</param>
//        /// <param name="args">Optional arguments to be string.formatted into the message.</param>
//        private static Exception CreateFault(ErrorCode errorCode, string message, params object[] args)
//        {
//            // TODO: We want to remove the LegacyWebFault with the next major version GAP-593 
//            Exception fault;

//            const string advancedErrorCodesHeaderText = "AdvancedErrorCodes";
//            bool useAdvancedErrorCodes = false;

//            if (WebOperationContext.Current != null &&
//                WebOperationContext.Current.IncomingRequest.Headers.AllKeys.Contains(advancedErrorCodesHeaderText))
//            {
//                string advancedErrorCodesValue = WebOperationContext.Current.IncomingRequest.Headers[advancedErrorCodesHeaderText];

//                bool.TryParse(advancedErrorCodesValue, out useAdvancedErrorCodes);
//            }

//            if (useAdvancedErrorCodes)
//            {
//                if (args != null && args.Any())
//                {
//                    fault = new SimpleWebFault(string.Format(message, args), errorCode);
//                }
//                else
//                {
//                    fault = new SimpleWebFault(message, errorCode);
//                }
//            }
//            else
//            {
//                if (args != null && args.Any())
//                {
//                    fault = new LegacyWebFault(string.Format(message, args), errorCode);
//                }
//                else
//                {
//                    fault = new LegacyWebFault(message, errorCode);
//                }
//            }

//            return fault;
//        }
//    }
//}
