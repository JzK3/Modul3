using System.Xml.Linq;

namespace ConsoleApp3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Andy";
            byte age = 25;
            Boolean pet = true;
            double shoesize = 44.5;

            Console.WriteLine("{0}, Hello!", name);
            Console.WriteLine("Your age is {0}", age);
            Console.WriteLine("Do you have a pet? {0}",pet);
            Console.WriteLine("Your shoe size is - {0}", shoesize);
        }
    }
}
