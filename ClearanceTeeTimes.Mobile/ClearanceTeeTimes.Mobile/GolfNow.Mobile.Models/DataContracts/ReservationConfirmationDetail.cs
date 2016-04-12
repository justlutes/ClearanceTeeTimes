using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Information pertaining to a particular tee time reservation including the facility's detail.
    /// </summary>
    [DataContract]
    public class ReservationConfirmationDetail : ReservationConfirmation
    {
        /// <summary>
        /// The facility detail for the reservation at which the facility was made.
        /// </summary>
        [DataMember]
        public FacilityDetail Facility { get; set; }
    }
}
