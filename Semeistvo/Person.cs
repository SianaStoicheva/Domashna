using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semeistvo
{
    public class Person
    {
        public string Name;
        public int Age;

        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
