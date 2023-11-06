namespace CalculatorProgram
{
    public class Calculate
    {
        public decimal PerformCalculation(decimal num1, decimal num2, char oper)
        {
            decimal result = 0;
            bool valid = true;

            switch (oper)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        valid = false;
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            if (valid)
            {
                return result;
            }
            else
            {
                return -469864871481296421;
            }
        }
    }
}
