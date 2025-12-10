using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace VirtualPetApp
{
    class VirtualPet
    {
        private string name;
        private int age;
        private string type;

        private int hunger;
        private int happiness;
        private int bladder;

        public string Name => name;
        public int Age => age;
        public string Type => type;

        public VirtualPet(string name, int age, string type)
        {
            this.name = name;
            this.age = age;
            this.type = type;
            hunger = 50;
            happiness = 50;
            bladder = 50;

        }

        public void Feed()
        {

            hunger = Math.Max(100, hunger + 30);
            bladder = Math.Min(100, bladder + 20);

            if (hunger > 80)
            {
                Console.WriteLine($"{name} is full and happy!");
            }
            else
            {
                Console.WriteLine($"{name} is eating and looks very happy.");
            }
        }

        public void Pet()
        {
            happiness = Math.Min(100, happiness + 25);
            Console.WriteLine($"{name} purrs happily when you pet them.");
        }

        public void CheckToilet()
        {
            if (bladder >= 80)
            {
                Console.WriteLine($"{name} needs to go to the toilet!");
            }
            else if (bladder >= 50)
            {
                Console.WriteLine($"{name} needs a toilet very soon!");
            }
            else
            {
                Console.WriteLine($"{name} is very content right now.");
            }
        }
}


}