using System;
using System.Net;

namespace GolfNow.Mobile.Models.WebFaults
{
    /// <summary>
    /// When added to an enum, describes the status code and description of an error code.
    /// </summary>
    public class ErrorCodeAttribute : Attribute
    {
        public HttpStatusCode Code
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }

        public ErrorCodeAttribute(string description, HttpStatusCode code)
        {
            this.Code = code;
        }
    }
}
