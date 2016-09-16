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

        //Properties

        //Constructors

        public VirtualPet(string type, string name)
        {
            petName = name;
            catOrDog = type;

            nutrition = 5;
            hydration = 5;
            socialization = 5;
            cleanliness = 5;
            energy = 5;

        }



        //Methods

        public void Feed()
        {

        }
    }
}
