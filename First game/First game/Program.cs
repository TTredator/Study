using System;

namespace First_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Welcome to our game. Input your name, please");
			string a = Console.ReadLine();
			Console.WriteLine("Ok, " + a + ", you need to pass our verification. Input your age,please");
			string a0 = Console.ReadLine();
			byte ageConverted = Convert.ToByte(a0);
			if (ageConverted < 12)
			{
				Console.WriteLine("Sorry, you're too young for playing this game");
			}
			else
			{
				Console.WriteLine("Wonderful, " + a + ". Let's start from choosing the race for you.\nType the number from 1 to 3 to choose the race for you");
			}
			string a1 = Console.ReadLine();
			byte ageConverted1 = Convert.ToByte(a1);
			if (ageConverted1 == 1)
			{
				Console.WriteLine("Good choice, " + a + "\nYour race is human. Have a nice game!");
			}
			else if (ageConverted1 == 2)
			{
				Console.WriteLine("Great, " + a + "\nYour race is elves. Have a nice game!");
			}
			else if (ageConverted1 == 3)
			{
				Console.WriteLine("Wonderful, " + a + "\nYour race is gnomes. Have a nice game!");
			}
			else
			{
				Console.WriteLine("Sorry, " + a + " the number is incorrect. You need to type number from 1 to 3, not another");
			}
			Console.ReadLine();
		}
    }
}
