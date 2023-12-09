using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public Animal() 
        {
        }
        public bool IsMammal { get; set; }
        public int LegCount { get; set; }
        public bool IsAlive { get; set; }
        public int Age { get; set; }

    }
}
