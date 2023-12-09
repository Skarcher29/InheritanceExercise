using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            IsMammal = false;
            IsAlive = true;
            LegCount = 4;
            Age = 0;
        }
        public bool IsColdBlooded { get; set; }
        public bool IsScaly { get; set; }
        public bool CanGrowTail { get; set; }
        public string Habitat { get; set; }
    }
}
