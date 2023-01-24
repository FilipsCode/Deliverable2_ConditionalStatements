/*
Author: Filip Petersson
Date: 1/21/2023
Description: C# Console Application to provide practical examples of conditional statements.
*/
using System; // Calling library

namespace Deliverable_2ConditionalStatements;
class Program
{
    static void Main(string[] args)
    {
        try
    {
            Console.Write("Enter Your Grade:");
                int n1 = int.Parse(Console.ReadLine());

            if (n1 >= 1 && n1 < 60)
            {
                Console.WriteLine("Your letter grade in ISM 4300 is: F");
            }

            else if (n1 >= 60 && n1 < 70)
            {
                Console.WriteLine("Your letter grade in ISM 4300 is: D");
            }

            else if (n1 >= 70 && n1 < 80)
            {
                Console.WriteLine("Your letter grade in ISM 4300 is: C");
            }

            else if (n1 >= 80 && n1 < 90)
            {
                Console.WriteLine("Your letter grade in ISM 4300 is: B");
            }

            else if (n1 >= 90 && n1 <= 100)
            {
                Console.WriteLine("Your letter grade in ISM 4300 is: A");
            }

            else
            {
                Console.WriteLine("Grade value not valid");
            }
        }
        catch
        {
            Console.WriteLine("Not a valid entry, please enter a value between 1-100");
            Console.ReadKey(true);
            
        }
}

}