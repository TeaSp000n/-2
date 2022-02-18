using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Заповнiть анкету");

            User someUser = new User();

            Console.WriteLine("Логiн");
            someUser.Login = Console.ReadLine();
            Console.WriteLine("Name");
            someUser.Name = Console.ReadLine();
            Console.WriteLine("SureName");
            someUser.SureName = Console.ReadLine();
            Console.WriteLine("Years");
            someUser.Years = int.Parse(Console.ReadLine());
            Console.WriteLine("Date of writing");
            someUser.DateOf = int.Parse(Console.ReadLine());

            Console.WriteLine(someUser.GetUser());




            Console.WriteLine("Зроблено");
            Console.ReadKey();
        }
    }
}
