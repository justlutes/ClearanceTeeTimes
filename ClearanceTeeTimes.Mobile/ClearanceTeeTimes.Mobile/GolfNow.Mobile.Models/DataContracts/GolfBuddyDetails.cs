using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A golf buddy including read-only server calcualated values such as RoundsPlayedWithCount
    /// </summary>
    public class GolfBuddyDetails : GolfBuddy
    {
        /// <summary>
        /// Gets a read only count of the number of times that the golf buddy was played with.
        /// </summary>
        [DataMember]
        public int RoundsPlayedWithCount
        {
            get;
            set;
        }

    }
}
