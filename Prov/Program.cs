using System;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Heromanager!"); //just player directions
            Console.WriteLine("Press A to create a new hero, any other key will close the program.");

            string result = Console.ReadLine();

            if (result.ToUpper().Equals("A")) // checks if A
            {
                Hero one = new Hero(); //Creates a new hero
                Console.WriteLine("Here is your hero:");// hero showoff
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Program will now quit due to unethical user behaviour.");
                Console.ReadKey(); // finishes things if player wants to quit
            }

        }
    }

}
