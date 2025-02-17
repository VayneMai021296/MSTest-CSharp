using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Utilities
{
    public class EmailValidator
    {
        public bool IsValid(string email)
        {
            return email.Contains("@");
        }
    }
}
