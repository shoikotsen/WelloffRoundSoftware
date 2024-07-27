using System;

public class Program
{
    public static void Main()
    {
        // Salesperson details
        string[] salespeople = { "Danielle", "Edward", "Francis" };
        // Initials of the salespeople
        char[] initials = { 'D', 'E', 'F' };
         // Sales amounts for each salesperson
        double[] sales = new double[3];

        while (true)
        {
            // Prompt user to enter the initial of the salesperson or 'Z' to finish
            Console.Write("Enter salesperson initial (D, E, F) or Z to finish: ");
            char salesperson = Char.ToUpper(Console.ReadKey().KeyChar);// Read input and convert to uppercase
            Console.WriteLine();

            if (salesperson == 'Z')
            {
                // If user enters 'Z', exit the loop
                break;
            }
            // Find the position of the initial in the initials list
            int index = Array.IndexOf(initials, salesperson);

            if (index == -1)
            {
                // If the initial is not found, show an error message and ask again
                Console.WriteLine("intermediate output: Error, invalid salesperson selected, please try again");
                continue;
            }
            // Ask for the sale amount

            Console.Write("Enter sale amount: ");
            if (double.TryParse(Console.ReadLine(), out double saleAmount) && saleAmount >= 0)
            {
                // If the sale amount is valid, add it to the salesperson's total sales
                sales[index] += saleAmount;
            }
            else
            {
                // If the sale amount is not valid, show an error message and ask again
                Console.WriteLine("intermediate output: Error, invalid salesperson selected, please try again");
            }
        }

        // Variables to calculate totals and find the highest sales
        double grandTotal = 0;
        char highestSalesperson = ' ';
        double highestSales = 0;
         // Go through each salesperson's sales to find the totals
        for (int i = 0; i < sales.Length; i++)
        {
            // Show the sales for each salesperson
            Console.WriteLine($"Salesperson {initials[i]} ({salespeople[i]}): {sales[i]:C}");
            // Add to the grand total
            grandTotal += sales[i];

            if (sales[i] > highestSales)
            {
                // Update the highest sales and the salesperson with the highest sales
                highestSales = sales[i];
                highestSalesperson = initials[i];
            }
        }
        // Show the grand total sales and the salesperson with the highest sales
        Console.WriteLine($"Grand Total: {grandTotal:C}");
        Console.WriteLine($"Highest Sale: {highestSalesperson}");
    }
}
// 2024/06/20_SenShoikot_Exercise 5.1