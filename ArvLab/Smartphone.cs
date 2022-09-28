using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace ArvLab
{
    internal class Smartphone : Computer
    {
        // Property
        protected int NumOfSelfies { get; set; }

        // Inherits Computers constructor
        public Smartphone(int ram, int storage, string keyboard, int numOfSelfies = 0) : base(ram, storage, keyboard)
        {
            NumOfSelfies = numOfSelfies;
        }

        // Class methods
        public void TakeSelfie()
        {
            Console.WriteLine("Click! Selfie taken!");
            NumOfSelfies++;
            Console.WriteLine($"Total amount of selfies taken on this phone: {NumOfSelfies}");
        }

        // Class abstract/virtual methods
        public override void DeviceInformation()
        {
            Console.WriteLine($"Jag äger {base.ToString()} enheter");
            base.DeviceInformation();
            Console.WriteLine($"Total amount of selfies taken on this phone: {NumOfSelfies}");
        }
    }
}
