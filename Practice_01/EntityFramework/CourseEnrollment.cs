using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    // 👉 এই ক্লাসটি Course এবং Student এর মধ্যে
    // 👉 Many-to-Many Relationship represent করে
    // 👉 এটি একটি Junction / Bridge Table
    public class CourseEnrollment
    {
        // =========================
        // FOREIGN KEY → Course
        // =========================

        // 👉 Course টেবিলের Primary Key কে refer করে
        public int CourseId { get; set; }

        // 👉 Navigation Property
        // 👉 কোন Course এ enrollment করা হয়েছে
        public Course? Course { get; set; }


        // =========================
        // FOREIGN KEY → Student
        // =========================

        // 👉 Students2 টেবিলের Primary Key কে refer করে
        // 👉 Naming convention অনুযায়ী StudentId হলে ভালো হয়
        public int studentId { get; set; }

        // 👉 Navigation Property
        // 👉 কোন Student এই Course এ enroll করেছে
        public Students2? Student { get; set; }


        // =========================
        // EXTRA INFORMATION
        // =========================

        // 👉 কোন তারিখে Student Course এ enroll করেছে
        public DateTime EnrollmentDate { get; set; }

        // 👉 Student এই Course এর জন্য কত টাকা পরিশোধ করেছে
        public double paymentAmount { get; set; }
    }
}
