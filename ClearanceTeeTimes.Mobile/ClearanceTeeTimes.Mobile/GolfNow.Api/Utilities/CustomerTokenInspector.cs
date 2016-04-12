using System.Collections.Generic;
//using System.ServiceModel.Configuration;
//using System.ServiceModel.Web;
//using System.Web;

namespace GolfNow.Mobile.API.Utilities
{
    /// <summary>
    /// Adds the customer token (if available) into the header of the message.
    /// </summary>
    public class CustomerTokenInspector // : IClientMessageInspector, IParameterInspector
    {
        //private string _token = null;
		private Dictionary<string, int> _parameterToInspectMap = new Dictionary<string, int>();

		public Dictionary<string, int> ParameterToInspectMap
        {
			get
			{
				return _parameterToInspectMap;
			}
        }

        public CustomerTokenStore TokenStore
        {
            get;
            set;
        }

        /// <summary>
        /// If the _token was set by IParameterInspector.BeforeCall, use it.
        /// </summary>
        //object IClientMessageInspector.BeforeSendRequest(ref Message request, IClientChannel channel)
        //{
        //    if (!string.IsNullOrWhiteSpace(this._token))
        //    {
        //        var httpRequest = request.Properties[HttpRequestMessageProperty.Name] as HttpRequestMessageProperty;
        //        httpRequest.Headers.Add("CustomerToken", this._token);
        //    }
        //    return null;
        //}

        ///// <summary>
        ///// We have finished this call, so reset the _token attribute to prevent it being used by another call.
        ///// </summary>
        //void IParameterInspector.AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        //{
        //    this._token = null;
        //}

        ///// <summary>
        ///// Inspect the parameters to find the customer key, then look it up in the TokenStore.  If it is there, assign it
        ///// to _token so that it can be used by IClientMessageInspector.BeforeSendRequest.
        ///// </summary>
        //object IParameterInspector.BeforeCall(string operationName, object[] inputs)
        //{
        //    if (this.ParameterToInspectMap.ContainsKey(operationName.ToLower()) && this.TokenStore != null)
        //    {
        //        string customerid = inputs[this.ParameterToInspectMap[operationName.ToLower()]] as string;
        //        if (this.TokenStore.ContainsKey(customerid))
        //        {
        //            this._token = this.TokenStore[customerid];
        //        }
        //    }
        //    return null;
        //}

        //void IClientMessageInspector.AfterReceiveReply(ref Message reply, object correlationState)
        //{
        //    // NOOP
        //}
    }
}
