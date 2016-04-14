using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A data contract for course statistics.
    /// </summary>
    [DataContract]
    public class CourseStatistics
    {
        /// <summary>
        /// Gets or sets the course par.
        /// </summary>
        [DataMember]
        public byte? Par
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the number of holes.
        /// </summary>
        [DataMember]
        public byte? Holes
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the course length.
        /// </summary>
        [DataMember]
        public short? Yardage
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the course slope.
        /// </summary>
        [DataMember]
        public int? Slope
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the course rating.
        /// </summary>
        [DataMember]
        public decimal? Rating
        {
            get;
            set;
        }

        public override string ToString()
        {
            return string.Format("Par: {0}; Holes: {1}; Yardage: {2}; Slope: {3}; Rating: {4}", this.Par, this.Holes, this.Yardage, this.Slope, this.Rating);
        }
    }

}
