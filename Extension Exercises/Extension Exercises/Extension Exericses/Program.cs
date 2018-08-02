using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1, number2 = 0;                                                                        // these are varibales                                                                            
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

            Console.WriteLine("The" + choice + "Was Applied");                                               //the computer telling you the problem was solved
            Console.WriteLine("The End Result is :{0}\n You Are Welcome \n", final);                         // youre welcome for solving the problem for you
            Console.WriteLine("Press Any Key To Continue.....");                                             // this keeps the application open until you press any key

            Console.ReadLine();


        }
    }
}
