using System;

namespace Calc_addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double num1, num2, result;
                string operation;


                InputNum1();
                num1 = GetDoubleFromConsole();
                InputNum2();
                num2 = GetDoubleFromConsole();
                Operation();
                operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        result = Add(num1,num2);
                        BeautifulResult();
                        Console.WriteLine("The result is " + result);
                        Console.ResetColor();
                        break;

                    case "-":
                        result = Sub(num1, num2);
                        BeautifulResult();
                        Console.WriteLine("The result is " + result);
                        Console.ResetColor();
                        break;

                    case "*":
                        result = Mul(num1, num2);
                        BeautifulResult();
                        Console.WriteLine("The result is " + result);
                        Console.ResetColor();
                        break;
                    case "^":
                        result = Math.Pow(num1, num2);
                        BeautifulResult();
                        Console.WriteLine("The result is " + result);
                        Console.ResetColor();
                        break;

                    case "/":
                        if (num2 == 0)
                        {
                            ErrorResult();
                            
                        }
                        else
                        {
                            result = Div(num1,num2);
                            BeautifulResult();
                            Console.WriteLine("The result is " + result);
                            Console.ResetColor();

                        }
                        break;

                    default:
                        Console.WriteLine("Unknown operation. Choose the operation from the list");
                        break;
                }
                Console.ReadLine();


            }

        }

        public static void InputNum1()
        {
            Console.WriteLine("Input the first number");
        }

        public static double GetDoubleFromConsole()
        {
            do
            {
                if (double.TryParse(Console.ReadLine(), out double i))
                {
                    return i;
                }


            } while (true);
        }

        public static void InputNum2()
        {
            Console.WriteLine("Input the second number");
        }

        public static void Operation()
        {
            Console.WriteLine("Choose the operation. Type '+', '-', '*', '/', '^'");
        }

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Sub(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Mul(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Div(double num1, double num2)
        {
            {
                return num1 / num2;

            }

        }

        public static void BeautifulResult()
        {
            Console.SetCursorPosition(0, 20);
            Console.ForegroundColor = ConsoleColor.Green;
            
        }

        public static void ErrorResult()
        {
            Console.SetCursorPosition(0, 20);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Can't divide by 0");
            Console.ResetColor();
        }
    }
}
