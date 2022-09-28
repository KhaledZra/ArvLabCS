using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvLab
{
    // Base class
    internal class Computer
    {
        // Field
        private static int _devicesOwned = 0;
        // Property
        protected int Ram { get; set; }
        protected int Storage { get; set; }
        protected string Keyboard { get; set; }

        // Constructor
        protected Computer(int ram, int storage, string keyboard)
        {
            _devicesOwned++;
            Ram = ram;
            Storage = storage;
            Keyboard = keyboard;
        }

        // Class methods
        public void AddRam()
        {
            Console.WriteLine("Adding 1gb ram!");
            Ram += 1;
            Console.WriteLine($"Total ram for this device: {Ram}gb");
        }

        public void AddStorage()
        {
            Console.WriteLine("Adding 50gb storage!");
            Storage += 50;
            Console.WriteLine($"Total storage for this device: {Storage}gb");
        }

        // Class abstract/virtual methods
        public virtual void DeviceInformation()
        {
            Console.WriteLine($"Ram: {Ram}, Storage: {Storage}, Keyboard layout: {Keyboard}");
        }

        // Sends back amount of devices owned
        public override string ToString()
        {
            return _devicesOwned.ToString();
        }
    }
}
