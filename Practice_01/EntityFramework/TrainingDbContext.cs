using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace EntityFramework
{
    // 👉 এই ক্লাসটি আমাদের Database Context
    // 👉 DbContext এর মাধ্যমে Entity Framework ডাটাবেসের সাথে যোগাযোগ করে
    public class TrainingDbContext : DbContext
    {
        // 👉 Students2 টেবিলকে represent করে
        // 👉 Database এ Students2 নামে একটি টেবিল তৈরি হবে
        public DbSet<Students2> Students2 { get; set; }

        // 👉 Courses টেবিলকে represent করে
        public DbSet<Course> Courses { get; set; }

        // 👉 এই মেথডটি ডাটাবেসের connection configure করার জন্য ব্যবহার হয়
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 👉 যদি আগে থেকে কোন configuration না থাকে
            if (!optionsBuilder.IsConfigured)
            {
                // 👉 SQL Server এর জন্য connection string সেট করা হচ্ছে
                // Server  : SQL Server instance (SQLEXPRESS)
                // Database: ব্যবহৃত ডাটাবেসের নাম
                // User Id & Password: Authentication তথ্য
                // Trust Server Certificate: SSL certificate warning avoid করার জন্য
                optionsBuilder.UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=CSharpB22;User Id=CSharpB22;Password=624282;Trust Server Certificate=true"
                );

                // 👉 Parent class (DbContext) এর configuration কল করা হচ্ছে
                base.OnConfiguring(optionsBuilder);
            }
        }

        // 👉 এই মেথডটি দিয়ে Entity এবং Database table এর relationship configure করা হয়
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 👉 Topic entity কে Database এর Topics টেবিলের সাথে map করা হচ্ছে
            modelBuilder.Entity<Topic>().ToTable("Topics");

            // 👉 CourseEnrollment entity কে CourseEnrollments টেবিলের সাথে map করা হচ্ছে
            modelBuilder.Entity<CourseEnrollment>().ToTable("CourseEnrollments");

            // 👉 Composite Primary Key সেট করা হচ্ছে
            // 👉 CourseId এবং studentId মিলিয়ে একটি unique key তৈরি হবে
            modelBuilder.Entity<CourseEnrollment>()
                .HasKey(ce => new { ce.CourseId, ce.studentId });

            // 👉 Parent class এর OnModelCreating কল করা হচ্ছে
            base.OnModelCreating(modelBuilder);
        }
    }
}
