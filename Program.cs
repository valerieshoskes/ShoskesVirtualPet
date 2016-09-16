using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoskesVirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Virtual Pet Foster Simulator!");
            Console.WriteLine("Type \"Quit\" at any time to quit the game");
            Console.WriteLine("Raise all attributes to 20, and a family will adopt your pet!");
            Console.WriteLine("If a single attribute falls to 0, animal control will assign a more suitable foster...");
            string petType = "";
            do {
                Console.WriteLine("Would you like to foster a cat or a dog?");
                petType = Console.ReadLine().ToLower();
                QuitCheck(petType);
            }
            while (petType != "cat" && petType != "dog");
            Console.WriteLine("What is your {0}'s name?", petType);
            string petName = Console.ReadLine();
            QuitCheck(petName);
            VirtualPet myPet = new VirtualPet(petType, petName);
            Console.WriteLine("{0} has been through some rough times..", petName);
            Console.WriteLine("All their attributes are only at 5 :(");
            Console.WriteLine("But you can help {0}! Here they are:", petName);
            do
            {
                myPet.Tick();
                string input = Console.ReadLine();
                QuitCheck(input);
                switch (input)
                {
                    case "1":
                        myPet.Feed();
                        break;
                    case "2":
                        myPet.ProvideWater();
                        break;
                    case "3":
                        myPet.Play();
                        break;
                    case "4":
                        myPet.CleanWaste();
                        break;
                    case "5":
                        myPet.TuckIn();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }
            }
            while (true);

        }

        public static void QuitCheck(string quitInput)
        {
            if (quitInput.ToLower().Replace("\"", "") == "quit")
            {
                Console.WriteLine("Thank you for playing!");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
