//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Runtime.Serialization;
//using System.ServiceModel.Web;
//using System.Text;
//using System.Threading.Tasks;
//using GolfNow.Mobile.Models.DataContracts;

//namespace GolfNow.API.Contracts.WebFaults
//{
//    /// <summary>
//    /// A fault base class used to create quick faults based on status code and message.
//    /// </summary>
//    /[Serializable]
//    public class SimpleWebFault : WebFaultException<FaultContract>
//    {
//        public SimpleWebFault(string message, ErrorCode errorCode)
//            : base(new FaultContract() { ErrorCode = errorCode, Message = message }, errorCode.GetHttpStatusCode())
//        {
//            this.HResult = errorCode.GetErrorCode();
//        }
//    }
//}