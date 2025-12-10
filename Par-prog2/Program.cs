using System;
using System.Timers; // Keep this for System.Timers.Timer

namespace VirtualPetApp
{
    class Program
    {
        static System.Timers.Timer tickTimer; // Fully qualify Timer to resolve ambiguity
        static void Main(string[] args)
        {
            Console.WriteLine("Name your pet:");
            string nameInput = Console.ReadLine();

            VirtualPet pet = new VirtualPet(nameInput);

            tickTimer = new System.Timers.Timer(1000);
            tickTimer.Elapsed += (s, e) => pet.Tick();
            tickTimer.Start();


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