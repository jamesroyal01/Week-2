using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercies
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1                                         

            Console.WriteLine("Please Enter Your Name");                  //user input
            string Name = Console.ReadLine();                             //the string is the variable and then it wants user input (you put in your name)
            Console.Write("Hello {0} \n", Name);                          //this is output and the computer replies to you
                                                   
            Console.ReadKey();

            Console.WriteLine("Please Enter Your Gender");
            string Gender = Console.ReadLine();
            Console.Write("You Gender Is {0} \n", Gender);

            Console.ReadKey();

            Console.WriteLine("Please Enter Your Address");
            string Address = Console.ReadLine();
            Console.Write("Your Address Is {0} \n", Address);

            Console.ReadKey();


            //Task 2

            int number1 = 0;                                                                                 // this is a variable 
            int number2 = 0;                                                                                 //another variable
            int final = 0;
            String choice;

            Console.WriteLine("Please Enter The First Number");   
            number1 = Convert.ToInt32(Console.ReadLine());                                                   //this makes the number convert to output
            Console.WriteLine("What Do You Want To Do With These Numbers?: (+, *, / or -)");                 // asking the user for which symbol they want to use
            choice = Console.ReadLine();
            Console.WriteLine("Please Enter The Second Number");                                             //user input (asking you to put in the number you want)
            number2 = Convert.ToInt32(Console.ReadLine());

            if (choice == "+")                                                                               //this is where it gets worked out, if you typed in a + it will calculate here
            {
                final = number1 + number2;
            }

            if (choice == "-")
            {
                final = number1 - number2;
            }

            if (choice == "*")
            {
                final = number1 * number2;
            }

            if (choice == "/")
            {
                final = number1 / number2;
            }

            Console.WriteLine("The" + choice + "Was Applied");
            Console.WriteLine("The End Result is :{0}\n You Are Welcome \n", final);
            Console.WriteLine("Press Any Key To Continue.....");

            Console.ReadLine();

            
            //Task 3










        }
    }
}
