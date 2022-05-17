using System;

public class Program
{
	public static void Main()
	{
		while (true)
		{
			Console.Clear();
			double firstNum, secondNum, result;
			string operation;

			try
			{
				Console.WriteLine("Enter the first number");
				firstNum = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("Enter the second number");
				secondNum = Convert.ToDouble(Console.ReadLine());
			}
			catch (Exception)
			{
				Console.WriteLine("Ошибка");
				Console.ReadLine();
				continue;
			}

			Console.WriteLine("Choose the operation. Type '+', '-', '*', '/', ^");
			operation = Console.ReadLine();

			switch (operation)
			{
				case "+":
					result = firstNum + secondNum;
					Console.WriteLine("The result is " + result);
					break;

				case "-":
					result = firstNum - secondNum;
					Console.WriteLine("The result is " + result);
					break;

				case "*":
					result = firstNum * secondNum;
					Console.WriteLine("The result is " + result);
					break;
				case "^":
					result = Math.Pow(firstNum, secondNum);
					Console.WriteLine("The result is " + result);
					break;

				case "/":
					if (secondNum == 0)
					{
						Console.WriteLine("Can't divide by 0");
					}
					else
					{
						result = firstNum / secondNum;
						Console.WriteLine("The result is " + result);
					}
					break;

				default:
					Console.WriteLine("Unknown operation. Choose the operation from the list");
					break;
			}
			Console.ReadLine();
		}

	}

}