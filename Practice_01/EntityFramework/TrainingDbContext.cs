
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    public class TrainingDbContext : DbContext
    {
        public DbSet<Students2> Students2 { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=CSharpB22;User Id=CSharpB22;Password=624282;Trust Server Certificate = true");
        }
    }
}
