using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    public class CourseEnrollment
    {
        public int CourseId { get; set; }
        public Course? Course { get; set; }
        public int studentId { get; set; }
        public Students2? Student { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public double paymentAmount { get; set; }
    }
}
