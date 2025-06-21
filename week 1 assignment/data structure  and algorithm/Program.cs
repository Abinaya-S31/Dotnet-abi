using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("📊 Financial Forecasting Tool");
        Console.Write("Enter number of past months of data: ");
        int n;

        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("❌ Invalid input. Enter a positive number: ");
        }

        List<double> earnings = new List<double>();

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Enter earnings for month {i}: ₹");
            double amount;
            while (!double.TryParse(Console.ReadLine(), out amount) || amount < 0)
            {
                Console.Write("❌ Invalid amount. Try again: ₹");
            }
            earnings.Add(amount);
        }

        double average = earnings.Average();
        Console.WriteLine($"\n📈 Average Monthly Earnings: ₹{average:F2}");

        // Simple forecast logic: assume next month = average + 10%
        double forecast = average * 1.10;
        Console.WriteLine($"🔮 Forecast for next month: ₹{forecast:F2}");
    }
}

