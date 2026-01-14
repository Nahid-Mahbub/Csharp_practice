using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    // এই ক্লাসটি হচ্ছে আমাদের Database Context
    // DbContext এর মাধ্যমে Entity Framework ডাটাবেসের সাথে যোগাযোগ করে
    public class TrainingDbContext : DbContext
    {
        // এই DbSet টি Students2 টেবিলকে represent করে
        // Database এ Students2 নামে একটি টেবিল থাকবে
        public DbSet<Students2> Students2 { get; set; }

        // এই মেথডটি ডাটাবেসের connection configure করার জন্য ব্যবহার হয়
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // যদি আগে থেকে কোন configuration না থাকে
            if (!optionsBuilder.IsConfigured)
            {
                // এখানে SQL Server এর connection string দেওয়া হয়েছে
                // Server = SQL Server instance
                // Database = কোন ডাটাবেস ব্যবহার হবে
                // User Id & Password = authentication তথ্য
                // Trust Server Certificate = certificate error avoid করার জন্য
                optionsBuilder.UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=CSharpB22;User Id=CSharpB22;Password=624282;Trust Server Certificate=true"
                );
            }
        }
    }
}
