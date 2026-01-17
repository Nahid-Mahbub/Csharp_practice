using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    // 👉 এই ক্লাসটি ডাটাবেসের Topic টেবিলকে represent করে
    // 👉 একটি Course এর অধীনে একাধিক Topic থাকতে পারে
    public class Topic
    {
        // 👉 Primary Key
        // 👉 Auto Increment IDENTITY column
        public int Id { get; set; }

        // 👉 Topic এর শিরোনাম / নাম
        // 👉 Database এ nvarchar টাইপ হিসেবে সংরক্ষিত হবে
        public string? Title { get; set; }

        // 👉 Topic টি কত ঘণ্টা পড়ানো হবে
        // 👉 Course এর মোট duration এর অংশ
        public int DurationInHours { get; set; }

        // =========================
        // FOREIGN KEY → Course
        // =========================

        // 👉 Course টেবিলের Primary Key কে refer করে
        // 👉 এটি Foreign Key
        public int CourseId { get; set; }

        // 👉 Navigation Property
        // 👉 কোন Course এর অন্তর্ভুক্ত এই Topic
        public Course? Course { get; set; }
    }
}
