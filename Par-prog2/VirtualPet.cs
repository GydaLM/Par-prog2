/*Lag en konsoll-applikasjon hvor man kan generere opp flere forskjellige virtuelle kjæledyr.
Bruk constructor i klassen, og man skal ikke ha lov til å endre data som navn,
age eller noen andre egenskaper utenfra klassen.
Lag funksjonalitet som gjør at man kan gi dyret mat, kose med dyret eller sjekke om dyret må på do
Her er et eksempel på hvordan det kan se ut:
Hvilket dyr vil du ta vare på?
Pikachu
1. Gi Pikachu mat
2. Kos med Pikachu
3. Sjekk om Pikachu må på do
2
Pikachu smiler!
1. Gi Pikachu mat
2. Kos med Pikachu
3. Sjekk om Pikachu må på do
1
Pikachu er mett og fornøyd
*/

namespace VirtualPetApp
{
    class VirtualPet
    {
        private string name;
        private int age;

        private int hunger;
        private int happiness;
        private int bladder;

        public string Name => name;
        public int Age => age;

        public VirtualPet(string name, int age)
        {
            this.name = name;
            this.age = age;
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