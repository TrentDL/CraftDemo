/*
 * Craft System
 * Trent Landsberger
 * Application created in PROG 201 Programming I
 * With code demos from Baxter, Janell
 * Spring 2025
 */

using static System.Console;

namespace TrentCraftingDemo
{
    internal class Program
    {
        static void Main() //args "stands for arguments"
        {
            //player name input
            WriteLine("What's your name?");

            string name = Console.ReadLine();

            Console.ReadKey();

            Console.WriteLine("Hello " +  name);

            WriteLine("enter a character");
            string character = Console.ReadLine();


            //rows
            for(int i = 0; i <10; i++)
            {
                Console.WriteLine(character);
            }

            for (int j = 0; j < 10; j++)
            {
                Console.Write(character);
            }



            string[,] locations = { 
                { "a", "b", "c" },
                { "d", "e", "f" },
                { "g", "h", "i" }
            };
            for (int i = 0; i < locations.Length; i++)
            {
                Console.WriteLine(locations[i]);
            }

            Console.Title = "app name";
            new Engine().Run();

            //alt option below
            //Engine engine = new Engine();
            // engine.Setup();

            




        }
    }
}
