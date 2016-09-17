using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoskesVirtualPet
{
    class VirtualPet
    {
        //Fields
        private string catOrDog;
        private string petName;

        private int nutrition;
        private int hydration;
        private int socialization;
        private int cleanliness;
        private int energy;
        private int steps;

        private int difficulty;

        //Properties

        public string CatOrDog
        {
            get { return this.catOrDog; }
            set { this.catOrDog = value; }
        }

        public string Name
        {
            get { return this.petName; }
            set { this.petName = value; }
        }

        public int Nutrition
        {
            get { return this.nutrition;  }
            set { this.nutrition = value; }
        }

        public int Hydration
        {
            get { return this.hydration; }
            set { this.hydration = value; }
        }

        public int Socialization
        {
            get { return this.socialization; }
            set { this.socialization = value; }
        }

        public int Cleanliness
        {
            get { return this.cleanliness; }
            set { this.cleanliness = value; }
        }

        public int Energy
        {
            get { return this.energy; }
            set { this.energy = value; }
        }

        public int Steps
        {
            get { return this.steps; }
            set { this.steps = value; }
        }

        public int Difficulty
        {
            get { return this.difficulty; }
            set { this.difficulty = value; }
        }
        //Constructors

        public VirtualPet(string type, string name, int difficulty)
        {
            petName = name;
            catOrDog = type;

            nutrition = difficulty;
            hydration = difficulty;
            socialization = difficulty;
            cleanliness = difficulty;
            energy = difficulty;

        }



        //Methods

        public void Feed()
        {
            Console.WriteLine("You feed {0} a nutritious meal!", Name);
            Nutrition += 3;
            Hydration--;
            Socialization++;
            Cleanliness--;
            Energy--;
            Steps++;
        }

        public void ProvideWater()
        {
            Console.WriteLine("You offer {0} some cool, filtered water!", Name);
            Nutrition++;
            Hydration += 3;
            Cleanliness--;
            Steps++;
         
        }

        public void Play()
        {
            Console.WriteLine("You play with {0} and you both have fun!", Name);
            Nutrition--;
            Hydration--;
            Socialization += 4;
            Energy--;
            Steps++;
        }

        public void CleanWaste()
        {
            Console.WriteLine("You clean up {0}'s waste. Stinky, but necessary...", Name);
            Socialization--;
            Cleanliness += 3;
            Steps++;
        }

        public void TuckIn()
        {
            Console.WriteLine("You tuck {0} in for the night. Good night {0}!", Name);
            Nutrition--;
            Hydration--;
            Socialization--;
            Energy += 4;
            Steps++;
        }

        public void StatusCheck()
        {
            if (Nutrition <= 0 || Hydration <= 0 || Socialization <= 0 || Cleanliness <= 0 || Energy <= 0)
            {
                Console.WriteLine("You haven't been taking care of {0} very well..", Name);
                Console.WriteLine("Animal control was called in time, {0} is going to a better foster family.", Name);
                Console.WriteLine("YOU LOSE");
                Console.ReadKey();
                Environment.Exit(0);

            }
            else if (Nutrition >= 20 && Hydration >= 20 && Socialization >= 20 && Cleanliness >= 20 && Energy >= 20)
            {
                Console.WriteLine("Nutrition is at: " + Nutrition);
                Console.WriteLine("Hydration is at: " + Hydration);
                Console.WriteLine("Socialization is at: " + Socialization);
                Console.WriteLine("Cleanliness is at: " + Cleanliness);
                Console.WriteLine("Energy is at: " + Energy);
                Console.WriteLine("\n\n");
                Console.WriteLine("You took excellent care of {0}!", Name);
                Console.WriteLine("A wonderful family is adopting them, and they'll always remember their time with you!");
                Console.WriteLine("__     __           _____  _      _   _   _  _ ");
                Console.WriteLine("\\ \\   / /          | __  \\ (_)   | | (_) | || |");
                Console.WriteLine(" \\ \\_/ /__  _   _  | |  | | _  __| | | |_| || |");
                Console.WriteLine("  \\   / _ \\| | | | | |  | || |/ _` | | |__ || |");
                Console.WriteLine("   | | (_) | |_| | | |__| || | (_| | | | | ||_|");
                Console.WriteLine("   |_|\\___ /\\__,_| | _____/|_|\\__,_| |_| \\__(_)");
                Console.WriteLine("You won in {0} steps. See if you can improve your score by playing again!", Steps);
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
        public void Tick()
        {
            StatusCheck();
            Console.Write("\n\n\n");
            if (catOrDog == "cat")
            {
                Console.WriteLine("  /\\___/\\");
                Console.WriteLine(" ( ^   ^ )");
                Console.WriteLine(" (  =-=   )");
                Console.WriteLine(" (         )");
                Console.WriteLine(" (          )");
                Console.WriteLine(" ( oo   oo   )))))))))))");
            }
            else
            {
                Console.WriteLine("    ___  ");
                Console.WriteLine("  //^ ^\\\\");
                Console.WriteLine(" (/(_•_)\\)");
                Console.WriteLine(" _/''*''\\_");
                Console.WriteLine(" (,,,)^(,,,) ");
            }
            Console.Write("\n\n");
            Console.WriteLine("Here is {0}'s current state:", Name);
            Console.WriteLine();
            Console.WriteLine("Nutrition is at: "+Nutrition);
            Console.WriteLine("Hydration is at: " + Hydration);
            Console.WriteLine("Socialization is at: " + Socialization);
            Console.WriteLine("Cleanliness is at: " + Cleanliness);
            Console.WriteLine("Energy is at: " + Energy);
            Console.Write("\n\n");
            Console.WriteLine("Press 1 to feed, 2 to provide water, 3 to play, 4 to clean up waste,");
            Console.WriteLine("or 5 to tuck in for the night");

        }
    }
}
