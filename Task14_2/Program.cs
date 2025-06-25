namespace Task14_2
{
    internal class Program
    {
        public delegate void  MyDelegate(string deviceName, string massage);
        public class Light
        {
            public bool LightIsON { get; set; } = false;
        }
        public class Thermostat
        {
            public int ThermostatTemperature { get; set; } = 22;
        }
        public class Door
        {
            public bool DoorIsLock { get; set; } = false;
        }
       
        public class SmartHomeSystem
        {
            public event MyDelegate MyDelegate;

            Light Light { get; set; } = new Light();
            Thermostat Thermostat { get; set; } = new Thermostat();
            Door Door { get; set; } = new Door();


            public void TurnOnLight()
            {
                Light.LightIsON = true;
                MyDelegate.Invoke($"{nameof(Light)}", "Включен");
            }
            public void TurnOffLight()
            {
                Light.LightIsON = false;
                MyDelegate.Invoke($"{nameof(Light)}", "Выключен");
            }
            public void SetTemperature(int newTemp)
            {
                Thermostat.ThermostatTemperature = newTemp;
                MyDelegate.Invoke($"{nameof(Thermostat)}", $"Температруа изменена! Новая температура: {Thermostat.ThermostatTemperature}°C");
            }
            public void LockDoor()
            {
                Door.DoorIsLock = true;
                MyDelegate.Invoke($"{nameof(Door)}", "Закрыта");

            }
            public void UnlockDoor()
            {
                Door.DoorIsLock = false;
                MyDelegate.Invoke($"{nameof(Door)}", "Открыта");

            }

        }
        static void Main(string[] args)
        {
            var smartHomeSystem = new SmartHomeSystem();
            smartHomeSystem.MyDelegate += (string deviceName, string message) =>
            {
                Console.WriteLine($"[{DateTime.Now}] {deviceName}: {message}" );
            };
            smartHomeSystem.UnlockDoor();
            smartHomeSystem.LockDoor();
            smartHomeSystem.SetTemperature(18);
            smartHomeSystem.TurnOnLight();
            smartHomeSystem.TurnOffLight();

            Console.ReadKey();
        }
    }
}
