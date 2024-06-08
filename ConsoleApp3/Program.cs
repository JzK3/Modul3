using System.Xml.Linq;

namespace ConsoleApp3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You favorite color please");
            var color = Console.ReadLine();
            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(" You picked Red color");
            }
            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" You picked Green color");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" You picked Cyan color");
            }
        }
    }
}