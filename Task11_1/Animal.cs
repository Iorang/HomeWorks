using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_1
{
    public abstract class Animal
    {
        public abstract string Name { get; }

        public abstract string Say();
        public void ShowInfo()
        {
            Console.WriteLine("Животное: " + Name);
            Console.WriteLine("Издает звук: " + Say());
        }
    }
}
