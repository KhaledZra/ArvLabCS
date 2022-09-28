using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvLab
{
    // Inheritance
    internal class Laptop : Computer
    {
        // Property
        protected float Weight { get; set; }

        // Inherits Computers constructor
        public Laptop(int ram, int storage, string keyboard, float weight) : base(ram, storage, keyboard)
        {
            Weight = weight;
        }

        // Class methods
        private void WeightCheck()
        {
            Console.WriteLine($"Laptop weight is: {Weight}Kg");
        }

        // Class abstract/virtual methods
        public override void DeviceInformation()
        {
            Console.WriteLine($"Jag äger {base.ToString()} enheter");
            base.DeviceInformation();
            WeightCheck();
        }
    }
}
