using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    [DataContract]
    public class MasterCourse
    {
        [DataMember]
        public int MasterCourseID { get; set; }

        [DataMember]
        public int SourceSystemID { get; set; }

        [DataMember]
        public int? ReviewID { get; set; }

        [DataMember]
        public int? FacilityID { get; set; }

        [DataMember]
        public int? CourseID { get; set; }

        [DataMember]
        public string FacilityName { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string URL { get; set; }

        [DataMember]
        public string ImageURL { get; set; }

        [DataMember]
        public int? NumCourses { get; set; }

        [DataMember]
        public string Company { get; set; }

        [DataMember]
        public string CourseCity { get; set; }

        [DataMember]
        public string CourseState { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public decimal? CourseLatitude { get; set; }

        [DataMember]
        public decimal? CourseLongitude { get; set; }

        [DataMember]
        public string MgmtCo { get; set; }

        [DataMember]
        public string Contact { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string CourseName { get; set; }

        [DataMember]
        public int? Holes { get; set; }

        [DataMember]
        public string HoleType { get; set; }
        
        [DataMember]
        public int? TotalYards { get; set; }

        [DataMember]
        public int? Par { get; set; }
        
        [DataMember]
        public string ArchitectName { get; set; }

        [DataMember]
        public DateTime? DateOpened { get; set; }

        [DataMember]
        public decimal? Rating { get; set; }

        [DataMember]
        public int? Slope { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string GuestPolicy { get; set; }

        [DataMember]
        public int? RegionAreaID { get; set; }

        [DataMember]
        public int? GolfFacilityID { get; set; }

        [DataMember]
        public int? BinaryCheckSum { get; set; }

        [DataMember]
        public int? RowHash { get; set; }
    }
}
