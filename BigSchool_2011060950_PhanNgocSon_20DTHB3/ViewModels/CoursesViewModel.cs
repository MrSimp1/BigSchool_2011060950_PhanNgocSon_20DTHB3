using BigSchool_2011060950_PhanNgocSon_20DTHB3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool_2011060950_PhanNgocSon_20DTHB3.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }

    }
}