using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    // 👉 এই ক্লাসটি ডাটাবেসের Students2 টেবিলকে represent করে
    // 👉 Entity Framework এই ক্লাস দেখে টেবিলের structure তৈরি করে
    public class Students2
    {
        // 👉 Primary Key
        // 👉 EF Core নিজে থেকেই এটাকে IDENTITY (Auto Increment) হিসেবে সেট করে
        public int Id { get; set; }

        // 👉 শিক্ষার্থীর নাম সংরক্ষণের জন্য
        // 👉 Database এ এটি nvarchar টাইপ হিসেবে সংরক্ষিত হবে
        // 👉 '?' দেওয়া মানে null value গ্রহণযোগ্য
        public string? Name { get; set; }

        // 👉 শিক্ষার্থীর CGPA সংরক্ষণের জন্য
        // 👉 double টাইপ numeric value রাখার জন্য ব্যবহৃত হয়
        public double CGPA { get; set; }

        // 👉 শিক্ষার্থীর জন্ম তারিখ সংরক্ষণের জন্য
        // 👉 Database এ এটি datetime টাইপ হিসেবে থাকবে
        public DateTime DateOfBirth { get; set; }

        // 👉 শিক্ষার্থী বর্তমানে Active কিনা বোঝায়
        // 👉 true  = Active
        // 👉 false = Inactive
        public bool IsActive { get; set; }

        // 👉 Navigation Property
        // 👉 একজন Student একাধিক Course এ Enroll করতে পারে
        // 👉 এটি Many-to-Many Relationship এর অংশ
        // 👉 CourseEnrollment হলো Junction Table
        public List<CourseEnrollment> EnrolledCourses { get; set; }
            = new List<CourseEnrollment>();
    }
}
