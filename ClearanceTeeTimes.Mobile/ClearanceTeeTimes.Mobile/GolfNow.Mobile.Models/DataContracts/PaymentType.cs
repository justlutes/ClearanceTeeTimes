using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{

    /// <summary>
    /// The accepted payment types for the customer's wallet
    /// </summary>
    [DataContract]
    public class PaymentType
    {

        /// <summary>
        /// Gets or sets the payment type identifier.
        /// </summary>
        /// <value>
        /// The payment type identifier.
        /// </value>
        [DataMember]
        public int PaymentTypeId { get; set; }


        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [DataMember]
        public string Name { get; set; }
    }
}
