//using System.ServiceModel.Configuration;
//using System.ServiceModel.Web;
//using System.Web;

namespace GolfNow.Mobile.API.Utilities
{
    /// <summary>
    /// Applies the parameter inspector operation to the operation if it has the AuthorizationAttribute specified in the service contract.
    /// </summary>
    public class CustomerTokenOperationBehavior //: IOperationBehavior
    {
        private CustomerTokenInspector _inspector;

        public CustomerTokenOperationBehavior(CustomerTokenInspector inspector)
        {
            this._inspector = inspector;
        }

        /// <summary>
        /// Applies the parameter inspector operation to the operation if it has the AuthorizationAttribute specified in the service contract.
        /// </summary>
        //void IOperationBehavior.ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation)
        //{
        //    ICustomerAuthorizationAttribute attribute = operationDescription.SyncMethod.GetCustomAttributes().Where(a => a is ICustomerAuthorizationAttribute).FirstOrDefault() as ICustomerAuthorizationAttribute;

        //    if (attribute != null && attribute.IsCustomerAuthorizationRequired)
        //    {
        //        // Resolve the named parameter to a parameter index for the ParameterInspector to use.
        //        IList<ParameterInfo> parameters = clientOperation.SyncMethod.GetParameters().ToList();
        //        ParameterInfo target = parameters.Where(a => a.Name.Equals(attribute.CustomerResourceIDParameter, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
        //        if (target != null)
        //        {
        //            if (target.ParameterType != typeof(string))
        //            {
        //                throw new Exception("The parameter that was specified by CustomerResourceIDParameter is not of type string.  Check the service contract.");
        //            }
        //            string methodName = clientOperation.SyncMethod.Name.ToLower();

        //            if (!this._inspector.ParameterToInspectMap.ContainsKey(methodName))
        //                this._inspector.ParameterToInspectMap.Add(methodName, parameters.IndexOf(target));

        //            clientOperation.ClientParameterInspectors.Add(this._inspector);
        //        }
        //        else
        //        {
        //            throw new Exception("Cannot attach parameter inspector to the parameter specified by CustomerResourceIDParameter because it does not exist.");
        //        }
        //    }
        //}

        //void IOperationBehavior.ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation)
        //{
        //    // NOOP
        //}

        //void IOperationBehavior.AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters)
        //{
        //    // NOOP
        //}

        //void IOperationBehavior.Validate(OperationDescription operationDescription)
        //{
        //    // NOOP
        //}
    }
}
