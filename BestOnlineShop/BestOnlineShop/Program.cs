using System;

namespace BestOnlineShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
			while (true)
			{
				Console.Clear();
				double trousersNum, shortsNum, tshirtsNum, bootsNum, shirtsNum;
				double trouserstotalprice = 0;
				double shortstotalprice = 0;
				double tshirtstotalprice = 0;
				double bootstotalprice = 0;
				double shirtstotalprice = 0;
				double result = 0;
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("Welcome to our Online shop. Do you want to see the list of clothes? Type 'yes'/'no'");
				string answer = null;

				while (answer != "yes")
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					answer = Console.ReadLine();
					Console.ResetColor();
					Console.WriteLine();
					switch (answer)
					{
						case "yes":
							Console.ForegroundColor = ConsoleColor.Blue;
							Console.WriteLine("OK, we'll show you the list of clothes. \nIf you want to buy something from our list - press the number from 1 to 5 for choosing clothes, which you want. Press 0 to finish your shopping");

							string[] clothesName = new string[5]
					{
		"1. Trousers - 20$", "2. Shorts - 15$", "3. T-shirt - 10$", "4. Boots - 30$", "5. Shirt - 25$"
					};
							for (int i = 0; i < clothesName.Length; i++)
								Console.WriteLine(clothesName[i] + " ");
							break;
						case "no":
							Console.ForegroundColor = ConsoleColor.Blue;
							Console.WriteLine("Good luck");
							break;
						default:
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine("incorrect format. Try to type only answers 'yes' or 'no'");
							break;
					}
				}
				string choice = null;
				do
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					choice = Console.ReadLine();
					switch (choice)
					{
						case "1":
							Console.ForegroundColor = ConsoleColor.Blue;
							Console.WriteLine("Good choice. How many trousers do you need?");
							Console.ForegroundColor = ConsoleColor.Yellow;
							trousersNum = double.Parse(Console.ReadLine());
							trouserstotalprice += 20 * trousersNum;
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine("You need to pay " + trouserstotalprice + "$ for " + trousersNum + " trousers. Press numbers from 1 to 5 to continue shopping. Press 0 to finish shopping");
							Console.WriteLine();
							break;
						case "2":
							Console.ForegroundColor = ConsoleColor.Blue;
							Console.WriteLine("Good choice. How many shorts do you need?");
							Console.ForegroundColor = ConsoleColor.Yellow;
							shortsNum = double.Parse(Console.ReadLine());
							shortstotalprice += 15 * shortsNum;
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine("You need to pay " + shortstotalprice + "$ for " + shortsNum + " shorts. Press numbers from 1 to 5 to continue shopping. Press 0 to finish shopping");
							Console.WriteLine();
							break;
						case "3":
							Console.ForegroundColor = ConsoleColor.Blue;
							Console.WriteLine("Good choice. How many T-shirts do you need?");
							Console.ForegroundColor = ConsoleColor.Yellow;
							tshirtsNum = double.Parse(Console.ReadLine());
							tshirtstotalprice += 10 * tshirtsNum;
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine("You need to pay " + tshirtstotalprice + "$ for " + tshirtsNum + " T-shirts. Press numbers from 1 to 5 to continue shopping. Press 0 to finish shopping");
							Console.WriteLine();
							break;
						case "4":
							Console.ForegroundColor = ConsoleColor.Blue;
							Console.WriteLine("Good choice. How many boots do you need?");
							Console.ForegroundColor = ConsoleColor.Yellow;
							bootsNum = double.Parse(Console.ReadLine());
							bootstotalprice += 30 * bootsNum;
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine("You need to pay " + bootstotalprice + "$ for " + bootsNum + " boots. Press numbers from 1 to 5 to continue shopping. Press 0 to finish shopping");
							Console.WriteLine();
							break;
						case "5":
							Console.ForegroundColor = ConsoleColor.Blue;
							Console.WriteLine("Good choice. How many shirts do you need?");
							Console.ForegroundColor = ConsoleColor.Yellow;
							shirtsNum = double.Parse(Console.ReadLine());
							shirtstotalprice += 25 * shirtsNum;
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine("You need to pay " + shirtstotalprice + "$ for " + shirtsNum + " shirts. Press numbers from 1 to 5 to continue shopping. Press 0 to finish shopping");
							Console.WriteLine();
							break;
						case "0":
							result = trouserstotalprice + shortstotalprice + tshirtstotalprice + bootstotalprice + shirtstotalprice;
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine("You need to pay " + result + " $ for your todays shopping. Input please the amount of money, that you'll give");
							Console.WriteLine();
							Console.ForegroundColor = ConsoleColor.Yellow;
							double sum = double.Parse(Console.ReadLine());
							double moneyRest = sum - result;
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine("Your money rest is " + moneyRest + ". Take please");
							break;
						default:
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine("Error. You need only write numbers from 1 to 5");
							break;
					}

				} while (choice != "0");
				Console.ReadLine();
			}
		}
    }
}
