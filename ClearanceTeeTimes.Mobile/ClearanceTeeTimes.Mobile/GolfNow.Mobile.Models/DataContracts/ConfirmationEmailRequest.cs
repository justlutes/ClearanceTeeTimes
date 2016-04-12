using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Base class for confirmation forwarding operations.
    /// </summary>
    [DataContract]
    [KnownType(typeof(ResendConfirmationRequest))]
    [KnownType(typeof(ResendMultipleConfirmationRequest))]
    [KnownType(typeof(ForwardConfirmationRequest))]
    [KnownType(typeof(ForwardMultipleConfirmationRequest))]
    public abstract class ConfirmationEmailRequest
    {
    }
}
