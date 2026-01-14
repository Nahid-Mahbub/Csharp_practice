using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    public class Students2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double CGPA { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsActive { get; set; }
    }
}
