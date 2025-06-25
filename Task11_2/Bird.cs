using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_2
{
    internal class Bird : IFlyable
    {
        public int MaxAltitude { get; set; }
        public Bird(int maxAltitude)
        {
            MaxAltitude = maxAltitude;
        }
        public void Fly()
        {
            Console.WriteLine($"Лечу на высоте {MaxAltitude} метров");
        }
    }
}
