namespace VirtualPetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name your pet:");
            string nameInput = Console.ReadLine();


            VirtualPet pet = new VirtualPet(nameInput, 1);

            while (true)
            {
                Console.WriteLine("\nWhat do you want to do?");
                Console.WriteLine($"1. Feed {pet.Name}");
                Console.WriteLine($"2. Pet {pet.Name}");
                Console.WriteLine($"3. Check if {pet.Name} needs the bathroom");
                Console.WriteLine("4. Quit");

                ConsoleKeyInfo menuChoice = Console.ReadKey();
                Console.WriteLine();

                switch (menuChoice.KeyChar)
                {
                    case '1':
                        pet.Feed();
                        break;

                    case '2':
                        pet.Pet();
                        break;

                    case '3':
                        pet.CheckToilet();
                        break;

                    case '4':
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}