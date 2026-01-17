using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    public class Course
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public double fees { get; set; }
        public  int durationInHours { get; set; }
        public List<Topic> Topics { get; set; } = new List<Topic>();
        public List<CourseEnrollment> CourseEnrollments { get; set; } = new List<CourseEnrollment>();
    }
}
