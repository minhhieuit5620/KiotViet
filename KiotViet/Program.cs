using System;

namespace KiotViet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter quantity coca");           
            if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity <= 0 || quantity >= 100000)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 99999.");
                return;
            }
            Ex1(quantity);
        }

        static void Ex1(int quantity)
        {                                
            int totalDrinks = 0;
            int emptyBottles = 0;
         
            totalDrinks += quantity;
            emptyBottles += quantity;
            
            while (emptyBottles >= 3)
            {
                int newBottles = emptyBottles / 3; 
                totalDrinks += newBottles;         
                emptyBottles = emptyBottles % 3 + newBottles; 
            }
           
            Console.WriteLine($"Total number of coca you can drink: {totalDrinks}");
        }
    }
}
