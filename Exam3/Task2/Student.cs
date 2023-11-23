using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Student : AbstractClass
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public override string GenerateId()
        {
            return "S-" + Name;
        }

        /*public string GenerateId()
        {
            return "S-" + Name;
        }*/
    }
}
