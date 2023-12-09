using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            IsMammal = false;
            LegCount = 2;
            IsAlive = true;
            Age = 0;
        }
        public int WingSpanCM { get; set; }
        public bool CanFly { get; set; }
        public string WingColor { get; set; }
        public bool DoMigrate { get; set; }
    }
}
