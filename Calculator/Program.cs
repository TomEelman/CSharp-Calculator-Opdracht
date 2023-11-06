using System;

namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool proceed = true;
            decimal num1;
            decimal num2;

            while (proceed)
            {
                do
                {
                    Console.WriteLine("Enter first number");
                    string inputUser1 = Console.ReadLine();

                    if (string.IsNullOrEmpty(inputUser1))
                    {
                        Console.WriteLine("You need to fill in the first number!!");
                        Console.WriteLine("");
                    }
                    else
                    {
                        if (decimal.TryParse(inputUser1, out num1))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("This input needs to be a valid number!!");
                            Console.WriteLine("");
                        }
                    }
                } while (true);

                do
                {
                    Console.WriteLine("Enter second number");
                    string inputUser2 = Console.ReadLine();

                    if (string.IsNullOrEmpty(inputUser2))
                    {
                        Console.WriteLine("You need to fill in the second number!!");
                        Console.WriteLine("");
                    }
                    else
                    {
                        if (decimal.TryParse(inputUser2, out num2))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("This input needs to be a valid number!!");
                            Console.WriteLine("");
                        }
                    }
                } while (true);

                Console.WriteLine("Choose operator: +, -, /, *");
                char oper = Convert.ToChar(Console.ReadLine());

                Calculate calculator = new Calculate();
                decimal result = calculator.PerformCalculation(num1, num2, oper);
                decimal result_rounded = Math.Round(result, 2);

                if (result == -469864871481296421)
                {
                    Console.WriteLine("Cannot divide by 0 !!");
                }
                else
                {
                    Console.WriteLine("Result: " + result_rounded);
                }

                Console.WriteLine("To proceed, type 'y' or 'yes', or 'n' or 'no' to stop:");
                string confirmation = Console.ReadLine().ToLower();

                if (confirmation == "y" || confirmation == "yes")
                {
                    proceed = true;
                }
                else if (confirmation == "n" || confirmation == "no")
                {
                    proceed = false;
                    Console.WriteLine("Calculator stopped.");
                    System.Threading.Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Invalid confirmation, Stopping calculator.");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(0);
                }
            }
        }
    }
}
