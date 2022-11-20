using System.Data.Common;

namespace method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculate(81, 3, "/");
        }
        static void calculate(int number1, int number2, string operators = "+,-,*,/")
        {
            switch (operators)
            {
                case "+":

                    Console.WriteLine(number1 + number2);
                    break;
                case "-":
                    Console.WriteLine(number1 - number2);
                    break;
                case "*":
                    Console.WriteLine(number1 * number2);
                    break;
                case "/":
                    Console.WriteLine(number1 / number2);
                    break;
                default:
                    break;
            }

        }
    }
}