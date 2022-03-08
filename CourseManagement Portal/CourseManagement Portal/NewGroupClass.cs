using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement_Portal
{
    public class NewGroupClass
    {
        public int GroupId { get; set; }
        public string? GroupName { get; set; }
        public int CourseId { get; set; }
        public DateTime PlannedStartDate { get; set; }
        public DateTime PlannedEndDate { get; set; }
    }

    public class NewGroupDGW
    {
        public int GroupId { get; set; }
        public string? GroupName { get; set; }
        public string? CourseName { get; set; }
        public DateTime PalnnedStartDate { get; set; }
        public DateTime PlannedEndDate { get; set; }
    }
}
