using System;

public class Program
{
    public static void Main()
    {
        // Salesperson details
        string[] salespeople = { "Danielle", "Edward", "Francis" };
        char[] initials = { 'D', 'E', 'F' };
        double[] sales = new double[3];

        while (true)
        {
            Console.Write("Enter salesperson initial (D, E, F) or Z to finish: ");
            char salesperson = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (salesperson == 'Z')
            {
                break;
            }

            int index = Array.IndexOf(initials, salesperson);

            if (index == -1)
            {
                Console.WriteLine("intermediate output: Error, invalid salesperson selected, please try again");
                continue;
            }

            Console.Write("Enter sale amount: ");
            if (double.TryParse(Console.ReadLine(), out double saleAmount) && saleAmount >= 0)
            {
                sales[index] += saleAmount;
            }
            else
            {
                Console.WriteLine("intermediate output: Error, invalid salesperson selected, please try again");
            }
        }

        // Calculate totals
        double grandTotal = 0;
        char highestSalesperson = ' ';
        double highestSales = 0;

        for (int i = 0; i < sales.Length; i++)
        {
            Console.WriteLine($"Salesperson {initials[i]} ({salespeople[i]}): {sales[i]:C}");
            grandTotal += sales[i];

            if (sales[i] > highestSales)
            {
                highestSales = sales[i];
                highestSalesperson = initials[i];
            }
        }

        Console.WriteLine($"Grand Total: {grandTotal:C}");
        Console.WriteLine($"Highest Sale: {highestSalesperson}");
    }
}
// 2024/06/20_SenShoikot_Exercise 5.1