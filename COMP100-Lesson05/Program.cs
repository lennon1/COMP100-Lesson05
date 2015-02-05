using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace COMP100_Lesson05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Your Code Here
            string prompt;
            string name;
            int age;

            Console.Write("Please Enter your name: ");
            prompt = Console.ReadLine();
            name = prompt;

            Console.Write("Please Enter your age: ");
            prompt = Console.ReadLine();

            age = Convert.ToInt32(prompt);


            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine();
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();





        }
    }
}
