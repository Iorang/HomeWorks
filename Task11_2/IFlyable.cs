using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_2
{
    public interface IFlyable
    {
         int MaxAltitude { get; set; }
         void Fly();
    }
}
