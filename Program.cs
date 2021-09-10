using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogDemo058
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int FirstNumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int secNumb = Convert.ToInt32(Console.ReadLine());
            AddNumber addNumber = new AddNumber();
            Console.WriteLine("Result:" + addNumber.Sum(FirstNumb, secNumb));
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
