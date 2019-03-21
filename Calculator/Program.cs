using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            string numb1;
            string numb2;
            string op;
            string choice;
            string choice1;
            string choice2;

            //numbers to be calculated
            double num1;
            double num2;

            //greets user
            Console.WriteLine("Welcome to the calculator");
            Console.WriteLine("here you must choose 2 numbers");
            Console.WriteLine("and the operation you want...");

            //sleeps for 1 second
            System.Threading.Thread.Sleep(1000);

            //instructions
            Console.WriteLine("Type + to add");
            Console.WriteLine("Type - to subtract");
            Console.WriteLine("Type * to multiply");
            Console.WriteLine("Type / to divide");
            Console.WriteLine("Type % for the remainder");
            Console.WriteLine("Type POW to do the power of");


            //asks for a number and stores it
            Console.Write("Enter a number: ");
            numb1 = Console.ReadLine();

            //asks for an operator and stores it
            Console.Write("Enter an operator: ");
            op = Console.ReadLine();

            //asks for a number and stores it
            Console.Write("Enter another number: ");
            numb2 = Console.ReadLine();

            //converting the inputs to doubles
            num1 = Convert.ToDouble(numb1);
            num2 = Convert.ToDouble(numb2);

            //adds numbers
            if (op == "+")
            {
                //outputs result
                Console.Write("Result: ");
                Console.WriteLine(num1 + num2);
            }
            //subtracts numbers
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            //multiplies numbers
            else if (op == "*")
            {
                //outputs result
                Console.Write("Result: ");
                Console.WriteLine(num1 * num2);
            }
            //divides and makes choice to user
            else if (op == "/")
            {
                //asks if wants to divide
                Console.WriteLine("You want to divide");
                Console.WriteLine(num1 + " by " + num2 + " (press 1)");
                Console.WriteLine("or " + num2 + " by " + num1 + " (press 2)?");
                choice = Console.ReadLine();

                //checks what operation the user wants
                if (choice == "1")
                {
                    //divides num1 by num2
                    //outputs result
                    Console.Write("Result: ");
                    Console.WriteLine(num1 / num2);
                }
                else if (choice == "2")
                {
                    //divides num2 by num1
                    //outputs result
                    Console.Write("Result: ");
                    Console.WriteLine(num2 / num1);
                }
                else
                {
                    //error message
                    Console.WriteLine("Invalid choice of numbers");
                }
            }
            //remainder
            else if (op == "%")
            {
                //asks if wants the reaminder of
                Console.WriteLine("You want the remainder of");
                Console.WriteLine(num1 + " by " + num2 + " (press 1)");
                Console.WriteLine("or " + num2 + " by " + num1 + " (press 2)?");
                choice1 = Console.ReadLine();

                //checks what operation the user wants
                if (choice1 == "1")
                {
                    //does the remainder of num1 by num2
                    //outputs result
                    Console.Write("Result: ");
                    Console.WriteLine(num1 % num2);
                }
                else if (choice1 == "2")
                {
                    //does the remainder of num2 by num1
                    //outputs result
                    Console.Write("Result: ");
                    Console.WriteLine(num2 % num1);
                }
                //if the user doesn't tipe a valid answer
                else
                {
                    //error message
                    Console.WriteLine("Invalid choice of numbers");
                }
            }
            //the power of
            else if (op == "POW")
            {
                //asks if wants the power of
                Console.WriteLine("You want the power of");
                Console.WriteLine(num1 + " by " + num2 + " (press 1)");
                Console.WriteLine("or " + num2 + " by " + num1 + " (press 2)?");
                choice2 = Console.ReadLine();

                //checks what operation the user wants
                if (choice2 == "1")
                {
                    //power of num1 by num2
                    //outputs result
                    Console.Write("Result: ");
                    Console.WriteLine(Math.Pow(num1, num2));

                }
                else if (choice2 == "2")
                {
                    //power of num2 by num1
                    //outputs result
                    Console.Write("Result: ");
                    Console.WriteLine(Math.Pow(num2, num1));
                }
                //if the user doesn't tipe a valid answer
                else
                {   
                    //error message
                    Console.WriteLine("Invalid choice of numbers");
                }
            }
            //if the user doesn't tipe a valid type of operator
            else
            {
                
                Console.WriteLine("Invalid choice of operator");
            }

            Console.ReadLine();
        }
    }
}
