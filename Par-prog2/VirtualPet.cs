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
        private bool isSick = false;

        private int hunger;
        private int happiness;
        private int bladder;

        public string Name => name;
        public bool IsSick => isSick;

        public VirtualPet(string name)
        {
            this.name = name;
            hunger = 50;
            happiness = 50;
            bladder = 50;

        }

        public void Tick()
        {
            hunger = Math.Max(0, hunger - 6);
            happiness = Math.Max(0, happiness - 5);
            bladder = Math.Min(100, bladder + 4);

            Console.WriteLine($"\n Time passes... {name}'s status has changed.");
            CheckHealth();
        }

        public void Feed()
        {

            hunger = Math.Min(100, hunger + 30);
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
                Console.WriteLine($"Take {name} to the bathroom?");
                Console.WriteLine("Yes/No");
                ConsoleKeyInfo menuChoice = Console.ReadKey();
                if(menuChoice.KeyChar == 'y')
                {
                    bladder = Math.Max(0, bladder - 50);
                }
            }
            else if (bladder >= 50)
            {
                Console.WriteLine($"{name} needs a toilet very soon!");
                Console.WriteLine($"Take {name} to the bathroom?");
                Console.WriteLine("Yes/No");
                ConsoleKeyInfo menuChoice = Console.ReadKey();
                if (menuChoice.KeyChar == 'y')
                {
                    bladder = Math.Max(0, bladder - 50);
                }
            }
            else
            {
                Console.WriteLine($"{name} is very content right now.");
            }
        }
        private void CheckHealth()
        {
            if (hunger < 10 || bladder > 90)
            {
                Console.WriteLine("Your pet has become sick!");
                isSick = true;
                Program.StopProgram();
            }
        }
    }
}