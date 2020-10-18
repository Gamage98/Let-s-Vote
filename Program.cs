using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vote
{
    class Program
    {
        private static string name;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name :");
                name = Console.ReadLine();
            Console.WriteLine("Enter your age :");
            int age=int.Parse(Console.ReadLine());
            if(age<18)
            {
                Console.WriteLine($"{name}, you are not eligible for voting");
            }
            
            else
            {
                Console.WriteLine($"Sorry {name}\nyou are eligible for voting");
            }
            
             if(age==18)
            {
                Console.WriteLine($"{name}, you are not eligible for voting Welcome for voting this is your first time you can get the help of guidlines");
            }
          
            Console.ReadKey();
        }
    }
}
