using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task16_1
{

    public class Computer
    {
        public string ComputerCode { get; set; }
        public string ComputerManufacturer { get; set; }
        public string CPUType { get; set; }
        public ushort ProcessorFrequency { get; set; }
        public byte AmountOfRAM { get; set; }
        public ushort AmountOfHDD { get; set; }
        public byte AmountOfVRAM { get; set; }
        public decimal Cost { get; set; }
        public uint Quantity { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computersList = new List<Computer>()
            {
                new Computer{ComputerCode = "105r-Hk2", ComputerManufacturer = "HP", CPUType = "Intel", ProcessorFrequency = 1800, AmountOfRAM = 4, AmountOfHDD = 500, AmountOfVRAM = 1, Cost = 15520, Quantity = 50},
                new Computer{ComputerCode = "202e-Lp9", ComputerManufacturer = "Lenovo", CPUType = "Ryzen", ProcessorFrequency = 2100, AmountOfRAM = 8, AmountOfHDD = 1000, AmountOfVRAM = 2, Cost = 21390, Quantity = 41},
                new Computer{ComputerCode = "118f-Lk1", ComputerManufacturer = "Lenovo", CPUType = "Intel", ProcessorFrequency = 2200, AmountOfRAM = 8, AmountOfHDD = 1000, AmountOfVRAM = 4, Cost = 25870, Quantity = 12},
                new Computer{ComputerCode = "958e-Ag7", ComputerManufacturer = "Acer", CPUType = "Intel", ProcessorFrequency = 4100, AmountOfRAM = 16, AmountOfHDD = 1000, AmountOfVRAM = 12, Cost = 88990, Quantity = 25},
                new Computer{ComputerCode = "746r-Af5", ComputerManufacturer = "Acer", CPUType = "Ryzen", ProcessorFrequency = 4600, AmountOfRAM = 16, AmountOfHDD = 1000, AmountOfVRAM = 12, Cost = 98490, Quantity = 80},
                new Computer{ComputerCode = "884r-Hd9", ComputerManufacturer = "HP", CPUType = "Intel", ProcessorFrequency = 3500, AmountOfRAM = 8, AmountOfHDD = 1000, AmountOfVRAM = 8, Cost = 59990, Quantity = 1},
                new Computer{ComputerCode = "641j-Hw6", ComputerManufacturer = "HP", CPUType = "Intel", ProcessorFrequency = 3500, AmountOfRAM = 12, AmountOfHDD = 1000, AmountOfVRAM = 8, Cost = 72700, Quantity = 36},
                new Computer{ComputerCode = "918w-Hw6", ComputerManufacturer = "Acer", CPUType = "Ryzen", ProcessorFrequency = 3500, AmountOfRAM = 12, AmountOfHDD = 1000, AmountOfVRAM = 12, Cost = 79700, Quantity = 38}
            };
            //все компьютеры с указанным процессором. Название процессора запросить у пользователя;
            Console.WriteLine("Список компьютеров:");
            foreach (var computer in computersList)
            {
                Console.WriteLine($"Код компьютера: {computer.ComputerCode}; Производитель компьютера: {computer.ComputerManufacturer};");
            }
            Console.WriteLine();

            Console.WriteLine("Компьютеры с каким типом процессора вывести в консоль(Intel или Ryzen)?");
            string? selectedProcessorType = Console.ReadLine();

            Console.WriteLine($"Компьютеры с типом процессора {selectedProcessorType}:");

            var selectedProcessorTypeList = (from d in computersList
                                                        where d.CPUType == selectedProcessorType
                                                        select d).ToList();

            foreach (var computer in selectedProcessorTypeList)
            {
                Console.WriteLine($"Код компьютера: {computer.ComputerCode}; Производитель компьютера: {computer.ComputerManufacturer}; Тип процессора: {computer.CPUType};");
            }
            Console.WriteLine();

            //все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
            Console.WriteLine("Компьютеры с каким минимальным объемом ОЗУ (Gb) вывести в консоль?");
            byte? selectedAmountOfRAM = Convert.ToByte(Console.ReadLine());

            var selectedAmountOfRAMList = computersList
                .Where(d => d.AmountOfRAM >= selectedAmountOfRAM)
                .ToList();

            foreach (var computer in selectedAmountOfRAMList)
            {
                Console.WriteLine($"Код компьютера: {computer.ComputerCode}; Производитель компьютера: {computer.ComputerManufacturer}; Объем ОЗУ: {computer.AmountOfRAM} Gb;");
            }
            Console.WriteLine();

            //вывести весь список, отсортированный по увеличению стоимости;
            Console.WriteLine("Список компьютеров отсортированный по увеличению стоимости:");

            var sortedByCostComputerList = computersList
                .OrderBy(p => p.Cost)
                .ToList();

            foreach (var computer in sortedByCostComputerList)
            {
                Console.WriteLine($"Код компьютера: {computer.ComputerCode}; Производитель компьютера: {computer.ComputerManufacturer}; Стоимость: {computer.Cost} у.е.");
            }
            Console.WriteLine();

            //вывести весь список, сгруппированный по типу процессора;
            Console.WriteLine("Список компьютеров сгруппированный по типу процессора:");

            var computerListGroupByCPUType = computersList.GroupBy(p => p.CPUType);

            foreach (var CPUType in computerListGroupByCPUType)
            {
                Console.WriteLine(CPUType.Key);

                foreach (var computer in CPUType)
                {
                    Console.WriteLine($"Код компьютера: {computer.ComputerCode}; Производитель компьютера: {computer.ComputerManufacturer};");
                }
            }
            Console.WriteLine();

            //найти самый дорогой и самый бюджетный компьютер;
            Console.WriteLine("Самый дорогой компьютер:");

            var coumputerWithMaxCost = computersList
                .Where(p => p.Cost == (computersList
                .Max(p => p.Cost)))
                .ToList()[0];

            Console.WriteLine($"Код компьютера: {coumputerWithMaxCost.ComputerCode}; Производитель компьютера: {coumputerWithMaxCost.ComputerManufacturer}; Стоимость: {coumputerWithMaxCost.Cost} у.е.");
            Console.WriteLine();

            Console.WriteLine("Самый дешевый компьютер:");

            var coumputerWithMinCost = computersList
                .Where(p => p.Cost == (computersList
                .Min(p => p.Cost)))
                .ToList()[0];

            //есть ли хотя бы один компьютер в количестве не менее 30 штук?
            Console.WriteLine($"Код компьютера: {coumputerWithMinCost.ComputerCode}; Производитель компьютера: {coumputerWithMinCost.ComputerManufacturer}; Стоимость: {coumputerWithMinCost.Cost} у.е.");
            Console.WriteLine();

            Console.Write("Есть ли хотя бы одна модель компютера количество которой больше 30 штук?: ");
            var computersCount = computersList.Count(p => p.Quantity >= 30);
            string result = computersCount != 0 ? "Да" : "Нет";
            Console.WriteLine(result);
                

            Console.ReadKey();
        }
    }
}
