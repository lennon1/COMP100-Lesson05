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
            bool happy;
            double money;
            double savings = 50.00d;
            double sum;

            Console.Write("Please Enter your name: ");
            prompt = Console.ReadLine();
            name = prompt;

            Console.Write("Please Enter your age: ");
            prompt = Console.ReadLine();

            age = Convert.ToInt32(prompt);

            Console.Write("{0}, are you happy (true or false)? ",name);
            prompt = Console.ReadLine();

            happy = Convert.ToBoolean(prompt);

            Console.Write("{0}, how much money do you have? ", name);
            prompt = Console.ReadLine();
            money = Convert.ToDouble(prompt);

            sum = money + savings;


            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine();
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine();
            Console.WriteLine("So, it is {0} that you are happy, eh?", happy);
            Console.WriteLine();
            Console.WriteLine("You said you have {0:C}", money);
            Console.WriteLine();
            Console.WriteLine("Here, take {0:C}, that should help...", savings);
            Console.WriteLine();
            Console.WriteLine("Now you have {0:C}. Have a great day!", sum);
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();





        }
    }
}
