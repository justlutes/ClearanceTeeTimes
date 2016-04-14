using System.Runtime.Serialization;
using GolfNow.Mobile.Models.Enumerations;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Describes a customer's preferred tee times by day of week and tee time for marketing purposes and site customization.
    /// </summary>
    [DataContract]
    public class PreferredTeeTimeRange
    {
        public PreferredTeeTimeRange(WeekDay dayOfWeek, TimeRange timeRange)
        {
            this.DayOfWeek = dayOfWeek;
            this.TimeRange = timeRange;
        }

        /// <summary>
        /// Gets or sets the day of week for this preferred tee time range.
        /// </summary>
        public WeekDay DayOfWeek
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a the integer value of DayOfWeek used for serialization.
        /// </summary>
        [DataMember(Name = "DayOfWeek")]
        private int DayOfWeekInt
        {
            get
            {
                return (int)DayOfWeek;
            }
            set
            {
                DayOfWeek = (WeekDay)value;
            }
        }


        /// <summary>
        /// Gets or sets the time range for this preferred tee time range
        /// </summary>
        public TimeRange TimeRange
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a the integer value of TimeRange used for serialization.
        /// </summary>
        [DataMember(Name = "TimeRange")]
        private int TimeRangeInt
        {
            get
            {
                return (int)TimeRange;
            }
            set
            {
                TimeRange = (TimeRange)value;
            }
        }


        public override bool Equals(object obj)
        {
            PreferredTeeTimeRange ptt = obj as PreferredTeeTimeRange;
            if (obj == null)
            {
                return base.Equals(obj);
            }
            else
            {
                return (this.DayOfWeek == ptt.DayOfWeek && this.TimeRange == ptt.TimeRange);
            }
        }

        public override int GetHashCode()
        {
            return this.DayOfWeek.GetHashCode() ^ this.TimeRange.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", DayOfWeek, TimeRange);
        }
    }
}
