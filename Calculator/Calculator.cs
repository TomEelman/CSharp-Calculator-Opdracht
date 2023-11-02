namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            bool proceed = true;

            while (proceed)
            {
                Console.WriteLine("Enter first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose operator: +, -, /, *");
                char oper = Convert.ToChar(Console.ReadLine());

                if (oper == '+' || oper == '-' || oper == '/' || oper == '*')
                {
                    Console.Write("Result:");
                    switch (oper)
                    {
                        case '+':
                            int sum_add = num1 + num2;
                            Console.WriteLine(sum_add);
                            break;
                        case '-':
                            int sum_min = num1 - num2;
                            Console.WriteLine(sum_min);
                            break;
                        case '/':
                            if (num1 < 1 || num2 < 1)
                            {
                                Console.WriteLine("Cannot divide by 0");
                            }
                            else
                            {
                                int sum_div = num1 / num2;
                                Console.WriteLine(sum_div);
                            }
                            break;
                        case '*':
                            int sum_mul = num1 * num2;
                            Console.WriteLine(sum_mul);
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
                }
                else
                {
                    Console.WriteLine("Invalid confirmation. Stopping calculator.");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(0);
                }
            }
        }
    }
}
