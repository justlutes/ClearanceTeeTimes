using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Describes settings for the distribution channel
    /// </summary>
    [DataContract]
    public class ChannelSettings
    {
        /// <summary>
        /// Gets or sets a value describing whether promo codes can be used on this channel.
        /// </summary>
        [DataMember]
        public bool IsPromoCodeEnabled
        {
            get;
            set;
        }
    }
}
