using System.Xml.Linq;

namespace ConsoleApp3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name - ");
            var name = Console.ReadLine();
            Console.Write("{0}!, Please enter your age - ",name);
            var age = checked((byte)int.Parse(Console.ReadLine()));
            Console.Write("{0}!, Please enter your birthdate (dd.mm.yyyy) - ", name);
            var birthdate = Console.ReadLine();
            Console.WriteLine("{0}!,your age is {1}, and  your bithdate is {2}", name, age, birthdate);
            Console.Write("What is your favorite day of week? ");
            var day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day);

        }
    }
}
         /* string name = "Andy";
            byte age = 25;
            Boolean pet = true;
            double shoesize = 44.5;

            Console.WriteLine("{0}, Hello!", name);
            Console.WriteLine("Your age is {0}", age);
            Console.WriteLine("Do you have a pet? {0}", pet);
            Console.WriteLine("Your shoe size is - {0}", shoesize);

            Console.WriteLine("IntMin {0} ", int.MinValue);
            Console.WriteLine("IntMax {0} ", int.MaxValue); 
            string name = "Jane";
            string age = "27";
            string favcolor = "black";
            Console.WriteLine("{0}\n{1}\n{2}",name,age,favcolor);
                Console.ReadKey();                              

 int a = 3, b = 1, c = 7;
 int res = a / ((b + c) % a);
 Console.WriteLine("RESULT = {0}",res);
 Console.ReadKey(); 

}
}

enum Semaphore
{
Red = 100,
Yellow = 200,
Green = 300
}
}
*/

