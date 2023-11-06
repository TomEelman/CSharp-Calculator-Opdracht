namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            bool proceed = true;
            decimal num1 = 0;
            decimal num2 = 0;

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
                }
                while (true);

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
                }
                while (true);

                Console.WriteLine("Choose operator: +, -, /, *");
                char oper = Convert.ToChar(Console.ReadLine());

                if (oper == '+' || oper == '-' || oper == '/' || oper == '*')
                {
                    switch (oper)
                    {
                        case '+':
                            decimal sum_add = num1 + num2;
                            decimal sum_add_roundedup = Math.Round(sum_add, 2);
                            Console.WriteLine("Result: " + sum_add_roundedup);
                            break;
                        case '-':
                            decimal sum_min = num1 - num2;
                            decimal sum_min_roundedup = Math.Round(sum_min, 2);
                            Console.WriteLine("Result: " + sum_min_roundedup);
                            break;
                        case '/':
                            if (num2 == 0)
                            {
                                Console.WriteLine("Cannot divide by 0");
                            }
                            else
                            {
                                decimal sum_div = num1 / num2;
                                decimal sum_div_roundedup = Math.Round(sum_div, 2);
                                Console.WriteLine("Result: " + sum_div_roundedup);
                            }
                            break;
                        case '*':
                            decimal sum_mul = num1 * num2;
                            decimal sum_mul_roundedup = Math.Round(sum_mul, 2);
                            Console.WriteLine("Result: " + sum_mul_roundedup);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid operator");
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
