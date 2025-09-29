using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_1
{
    public class Building
    {
        internal string _adsress;
        internal double _area;
        internal int _yearBuilt;
        internal int BuildingAge { get; set; }
        public Building(string adress, double area, int yearBuilt)
        {
            _adsress = adress;
            _area = area;
            _yearBuilt = yearBuilt;

            BuildingAge = DateTime.Now.Year - _yearBuilt;
        }

        public virtual double CalculateTax()
        {
            double tax;
            tax = _area * 1000;
            return tax;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Адрес: " + _adsress);
            Console.WriteLine("Площадь: " + _area);
            Console.WriteLine("Год постройки: " + _yearBuilt);
        }
    }
}
