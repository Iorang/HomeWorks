using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_1
{
    sealed class MultiBuilding : Building
    {
        private int _floors;
        private bool _hasElevator;

        private double _areaPerFloor;

        public double AreaPerFloor
        {
            get { return _areaPerFloor; }
        }

        public MultiBuilding(string adress, double area, int yearBuilt, int floors, bool hasElevator) : base(adress, area, yearBuilt)
        {
            _floors = floors;
            _hasElevator = hasElevator;
            _areaPerFloor = _area/_floors;
        }

        public override double CalculateTax()
        {
            double tax;
            double floorsCoefficient;
            int hasElevatorTax = 0;

            if (_hasElevator)
                hasElevatorTax = 5000;

            floorsCoefficient = (1 + (_floors - 1) * 0.05);

            tax = base.CalculateTax() + floorsCoefficient + hasElevatorTax;
            return tax;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Количество этажей: " + _floors);
            Console.WriteLine("Наличие лифта: " + _hasElevator);

        }


    }
}
