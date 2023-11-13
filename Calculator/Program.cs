using Calculator.Core;

namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool proceed = true;
            decimal number1;
            decimal number2;
            char operatorParam;
            while (proceed)
            {
                number1 = handleInput("Enter first number");
                number2 = handleInput("Enter second number");

                Console.WriteLine("Choose operator: +, -, /, *");
                operatorParam = Convert.ToChar(Console.ReadLine());

                CalculateService calculator = new CalculateService();
                var calculatedResult = calculator.PerformCalculation(number1, number2, operatorParam);
                if (!calculatedResult.IsSucces)
                {
                    Console.WriteLine(calculatedResult.ErrorMessage);
                }
                else
                {
                    Console.WriteLine("Result: " + calculatedResult.Result);
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
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Invalid confirmation, Stopping calculator.");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
            }
        }

        private static decimal handleInput(string questionText)
        {
            do
            {
                decimal inputValue;

                Console.WriteLine(questionText);
                string inputUser = Console.ReadLine();
                int decimalLength = inputUser.IndexOfAny(new char[] { '.', ',' });

                if (string.IsNullOrEmpty(inputUser))
                {
                    Console.WriteLine("You need to fill in this number!!");
                    Console.WriteLine("");
                }
                else
                {
                    if (decimal.TryParse(inputUser, out inputValue))
                    {
                        if (decimalLength != -1 && inputUser.Substring(decimalLength + 1).Length > 2)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Can only have 2 decimals behind the '.' or ','");
                            Console.WriteLine("");
                            continue;
                        }

                        return inputValue;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("This input needs to be a valid number!!");
                        Console.WriteLine("");
                    }

                }
            } while (true);
        }

    }
}
