using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Part5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade;
            Console.WriteLine("Enter the percentage\n");
            int grade =int.Parse(Console.ReadLine());
            if(grade > 90 ) 
            {
                Console.WriteLine("Above 90%");
            }
            else if(grade >70)
            {
                Console.WriteLine("Above 70-79%");
            }
            else if(grade> 60)
            {
                Console.WriteLine("Above 60%");
            }
            else
            {
                Console.WriteLine("Below 60%");
            }
            Console.ReadKey();
        }
    }
}
