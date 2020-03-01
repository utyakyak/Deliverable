using System;

namespace Deliverable
{
    class Program
    {
        static void PrintMessage(int waytoPrint)
        {
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            int result1 = n1 + n2;
            int result2 = n1 - n2;
            int result3 = n1 * n2;
            int result4 = n1 / n2;
            int result5 = n1 % n2;

            string msg1 = "The sum of " + n1 + " and " + n2 + " is: " + result1;
            string msg2 = "The difference between " + n1 + " and " + n2 + " is: " + result2;
            string msg3 = "The product of " + n1 + " and " + n2 + " is: " + result3;
            string msg4 = "The quotient of " + n1 + " and " + n2 + " is: " + result4 + " with a remainder of: " + result5;

            string[] myMessages = { msg1, msg2, msg3, msg4 };

            if (waytoPrint == 0)
            {
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine(myMessages[i]);
                }
            }
            else if (waytoPrint == 1)
            {
                for (int i = 1; i < 2; i++)
                {
                    Console.WriteLine(myMessages[i]);
                }
            }
            else if (waytoPrint == 2)
            {
                for (int i = 2; i < 3; i++)
                {
                    Console.WriteLine(myMessages[i]);
                }
            }
            else if (waytoPrint == 3)
            {
                for (int i = 3; i < 4; i++)
                {
                    Console.WriteLine(myMessages[i]);
                }
            }
            else if (waytoPrint == 4)
            {
                for (int i = 4; i < 3; i++)
                {
                    Console.WriteLine(myMessages[i]);
                }
            }
            else
            {
                Console.WriteLine("Hey buddy, what flag value is this?");
            }
        }
  
        static void Main(string[] args)
        {
            Console.WriteLine("Angelica Nguyen");

            Console.WriteLine("Enter the corresponding number for the mathematical operation you would like to perform below and then hit enter.");
            Console.WriteLine("1 Addition" + "\n" + "2 Subtraction" + "\n" + "3 Multiplication" + "\n" + "4 Division");

            int selection = Convert.ToInt32(Console.ReadLine());

            string msg = "Enter your first integer and hit enter, then enter your second integer and hit enter";

            if (selection == 1)
            {
                Console.WriteLine(msg);

                PrintMessage(0);
            }
            else if (selection == 2)
            {
                Console.WriteLine(msg);

                PrintMessage(1);
            }
            else if (selection == 3)
            {
                Console.WriteLine(msg);

                PrintMessage(2);
            }
            else if (selection == 4)
            {
                Console.WriteLine(msg);

                PrintMessage(3);
            }  
        }
    }
}
