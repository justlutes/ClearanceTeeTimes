using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    [DataContract]
    public class TeeTimePrice
    {
        /// <summary>
        /// Gets or sets the greens fees.
        /// </summary>
        [DataMember]
        public Money GreensFees
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the amount that is due online.
        /// </summary>
        [DataMember]
        public Money DueOnline
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the amount due at course (less taxes and fees).
        /// </summary>
        [DataMember]
        public Money DueAtCourse
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the amount of taxes and fees.
        /// </summary>
        [DataMember]
        public Money TaxesAndFees
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the sales tax total for this tee time.
        /// </summary>
        [DataMember]
        public Money SalesTaxTotal
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the total sum of transaction fees for this tee time.
        /// </summary>
        [DataMember]
        public Money TransactionFeesTotal
        {
            get;
            set;
        }
    }
}
