using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Utilities
{
    public class Student
    {
        public Student()
        {
            Name = string.Empty; // Initialize Name to an empty string to avoid CS8618
        }

        public int Id { get; set; }

        private string _name = string.Empty;
        public string Name { get { return _name; } set { _name = value; } }
    }
}
