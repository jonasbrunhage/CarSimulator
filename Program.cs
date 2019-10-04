using System;

namespace CarSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            bool running = true;

            while (running)
            {

                Console.WriteLine("1. Add car");
                Console.WriteLine("2. List cars");
                Console.WriteLine("3. Simulate speed");
                Console.WriteLine("4. Exit");

                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                Console.Clear();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        running = false;
                        break;

                }
                Console.Clear();
            }

        }
    }
}
