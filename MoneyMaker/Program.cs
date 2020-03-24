using System;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Money Maker

            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("How much do you want to convert?: ");
            string amount = Console.ReadLine();
            double amountInt = Convert.ToDouble(amount);
            Console.WriteLine($"{amountInt} cents is equal to ..");

            //Coins values
            int gold = 10;
            int silver = 5;

            //number of gold coins “fit” into the amount
            double goldCoins = Math.Floor(amountInt / gold);
            double remaining = amountInt % gold;

            //number of silver coins that “fit” into the remainder
            double silverCoins = Math.Floor(remaining / silver);
            double silverRemain = Math.Floor(remaining % silver);

            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            // number of bronze coins 
            Console.WriteLine($"Bronze coins: {silverRemain}");

        }
    }
}
