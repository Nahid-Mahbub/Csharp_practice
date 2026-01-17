using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    public class Topic
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int DurationInHours { get; set; }
        public int CourseId { get; set; }
        public Course? Course { get; set; }

    }
}
