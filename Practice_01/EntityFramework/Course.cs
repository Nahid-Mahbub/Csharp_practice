using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    // 👉 এই ক্লাসটি ডাটাবেসের Course টেবিলকে represent করে
    // 👉 Entity Framework এই ক্লাস দেখে Course টেবিল তৈরি করে
    public class Course
    {
        // 👉 Primary Key
        // 👉 Auto Increment IDENTITY column হিসেবে কাজ করে
        public int Id { get; set; }

        // 👉 Course এর নাম / শিরোনাম সংরক্ষণের জন্য
        // 👉 Database এ nvarchar টাইপ হিসেবে থাকবে
        public string? Title { get; set; }

        // 👉 Course এর মোট ফি সংরক্ষণের জন্য
        // 👉 double টাইপ monetary value রাখার জন্য
        public double fees { get; set; }

        // 👉 Course এর মোট duration (ঘণ্টায়)
        // 👉 কত ঘণ্টার কোর্স তা বোঝাতে ব্যবহার হয়
        public int durationInHours { get; set; }

        // 👉 Navigation Property
        // 👉 একটি Course এর অধীনে একাধিক Topic থাকতে পারে
        // 👉 One-to-Many Relationship (Course → Topics)
        public List<Topic> Topics { get; set; }
            = new List<Topic>();

        // 👉 Navigation Property
        // 👉 একটি Course এ অনেক Student enroll করতে পারে
        // 👉 Many-to-Many Relationship এর অংশ
        // 👉 CourseEnrollment হলো Junction Table
        public List<CourseEnrollment> CourseEnrollments { get; set; }
            = new List<CourseEnrollment>();
    }
}
