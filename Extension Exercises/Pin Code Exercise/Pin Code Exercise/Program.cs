using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin_Code_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50 / 10;                                                                       //Change these variables to what you want to see if what you enter is more or less thean 1000
            int b = 5 * 10;
            int c = 1000;

            if (a * b + c == 1000)                                                                 //if the asnwer is greater than 1000 this is correct. this is that varibles being multiplied, added, subtracted or divided
            {
                Console.WriteLine("The Answer Is Greater Than 1000");
            }
            else                                                                                   //else the answer is less then 1000
            {
                Console.WriteLine("The Answer Is Less Than 1000");                                 //the computer is telling you that the answer is less than 1000
            }

            Console.WriteLine("Press Any Key To Continue....");

            Console.ReadKey();                                                                     // press any key to continue/close the application
            .
        }
    }
}
