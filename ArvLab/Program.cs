using System.Threading.Channels;

namespace ArvLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop newLaptop = new(3, 64, "Nordic", 1.29f);
            Smartphone newSmartphone = new(3, 64, "Svenska");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Välj alternativ!");
                Console.WriteLine("1. Se information on din smartphone");
                Console.WriteLine("2. Se information on din bärbar dator");
                Console.WriteLine("3. Ta selfie med din smartphone");
                Console.WriteLine("4. Lägg till 1gb ram minne till din smartphone");
                Console.WriteLine("5. Lägg till 50gb lagring till din smartphone");
                Console.WriteLine("6. Lägg till 1gb ram minne till din bärbar dator");
                Console.WriteLine("7. Lägg till 50gb lagring till din bärbar dator");
                Console.WriteLine("8. Avslut programmet!");
                Console.Write("Val: ");
                Int32.TryParse(Console.ReadLine(), out int choice);

                Console.WriteLine("-----------------------------");
                if (choice <= 0 || choice >= 9) 
                {
                    Console.WriteLine("Fel val!");
                }
                else if (choice == 1)
                {
                    newSmartphone.DeviceInformation();
                }
                else if (choice == 2)
                {
                    newLaptop.DeviceInformation();
                }
                else if (choice == 3)
                {
                    newSmartphone.TakeSelfie();
                }
                else if (choice == 4)
                {
                    newSmartphone.AddRam();
                }
                else if (choice == 5)
                {
                    newSmartphone.AddStorage();
                }
                else if (choice == 6)
                {
                    newLaptop.AddRam();
                }
                else if (choice == 7)
                {
                    newLaptop.AddStorage();
                }
                else if (choice == 8)
                {
                    Console.WriteLine("Hejdå!");
                    Environment.Exit(0);
                }

                Console.WriteLine("-----------------------------");
                Console.Write("Tryck på valfri knapp för att returnera till menyn");
                Console.ReadKey();
            }
        }
    }
}