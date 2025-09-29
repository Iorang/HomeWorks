using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_2
{
    public class Airplane : IFlyable
    {
        public int CountPassengers { get; set; }
        public int MaxAltitude { get; set; }

        public Airplane(int maxAltitude, int countPassengers)
        {
            MaxAltitude = maxAltitude;
            CountPassengers = countPassengers;
        }

        public void Fly()
        {
            Console.WriteLine($"Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажиров");
        }
    }
}
