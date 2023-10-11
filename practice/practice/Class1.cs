using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Class1
    {
        public string firstName;
        public string lastName;

        public string GetName(string separator)
        {
            string fullName = firstName + separator + lastName;
            return fullName;
        }
    }
}
