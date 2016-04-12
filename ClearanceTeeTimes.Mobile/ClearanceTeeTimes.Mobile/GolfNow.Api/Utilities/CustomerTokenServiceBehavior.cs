//using System.ServiceModel.Configuration;
//using System.ServiceModel.Web;
//using System.Web;

namespace GolfNow.Mobile.API.Utilities
{
    /// <summary>
    /// Applies the CustomerTokenOperationBehavior to all operations on all endpoints.
    /// </summary>
    public class CustomerTokenServiceBehavior //: IEndpointBehavior
    {
        private CustomerTokenStore _store;

        public CustomerTokenServiceBehavior(CustomerTokenStore store)
        {
            this._store = store;
        }

        //void IEndpointBehavior.ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        //{
        //    if (this._store != null)
        //    { 
        //        CustomerTokenInspector inspector = new CustomerTokenInspector()
        //        {
        //            TokenStore = this._store
        //        };
        //        clientRuntime.MessageInspectors.Add(inspector);
        //        foreach (OperationDescription od in endpoint.Contract.Operations)
        //        {
        //            od.OperationBehaviors.Add(new CustomerTokenOperationBehavior(inspector));
        //        }
        //    }
        //}

        //void IEndpointBehavior.ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        //{
        //    // NOOP
        //}

        //void IEndpointBehavior.AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        //{
        //    // NOOP
        //}

        //void IEndpointBehavior.Validate(ServiceEndpoint endpoint)
        //{
        //    // NOOP
        //}
    }
}
