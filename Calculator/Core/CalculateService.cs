namespace Calculator.Core
{
    public class CalculateService
    {
        public CalculatorResult PerformCalculation(decimal number1, decimal number2, char oper)
        {
            decimal result = 0;

            {
                switch (oper)
                {
                    case '+':
                        result = number1 + number2;
                        break;
                    case '-':
                        result = number1 - number2;
                        break;
                    case '/':
                        if (number2 == 0)
                        {
                            return new CalculatorResult()
                            {
                                Result = 0,
                                IsSucces = false,
                                ErrorMessage = "Cannot divide by 0 !!"
                            };
                        }
                        else
                        {
                            result = number1 / number2;
                        }
                        break;
                    case '*':
                        result = number1 * number2;
                        break;
                    default:
                        return new CalculatorResult()
                        {
                            Result = 0,
                            IsSucces = false,
                            ErrorMessage = "Invalid operator"
                        };
                }
            }

            return new CalculatorResult()
            {
                Result = result,
                IsSucces = true,
                ErrorMessage = ""
            };
        }
    }
}
