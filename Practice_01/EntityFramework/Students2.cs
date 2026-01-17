using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    // এই ক্লাসটি ডাটাবেসের Students2 টেবিলকে represent করে
    // Entity Framework এই ক্লাসের মাধ্যমে টেবিলের structure বুঝে নেয়
    public class Students2
    {
        // এই property টি টেবিলের Primary Key
        // EF Core নিজে থেকেই এটাকে IDENTITY হিসেবে সেট করে
        public int Id { get; set; }

        // শিক্ষার্থীর নাম সংরক্ষণ করার জন্য
        // এটি ডাটাবেসে nvarchar টাইপ হিসেবে থাকবে
        public string? Name { get; set; }

        // শিক্ষার্থীর CGPA সংরক্ষণ করার জন্য
        public double CGPA { get; set; }

        // শিক্ষার্থীর জন্ম তারিখ সংরক্ষণ করার জন্য
        public DateTime DateOfBirth { get; set; }

        // শিক্ষার্থী বর্তমানে active কিনা তা বোঝানোর জন্য
        // true = active, false = inactive
        public bool IsActive { get; set; }

        public List<CourseEnrollment> EnrolledCourses { get; set; } = new List<CourseEnrollment>();
    }
}
