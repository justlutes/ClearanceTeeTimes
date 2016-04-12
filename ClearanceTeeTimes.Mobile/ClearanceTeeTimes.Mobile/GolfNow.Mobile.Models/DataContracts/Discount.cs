using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    [DataContract]
    public class Discount
    {
        /// <summary>
        /// The name of the discount
        /// </summary>
        [DataMember]
        public string DiscountName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the amount of the discount.
        /// </summary>
        [DataMember]
        public Money Amount
        {
            get;
            set;
        }
    }
}
