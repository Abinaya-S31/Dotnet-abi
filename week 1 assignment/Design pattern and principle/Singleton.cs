using System;

public class Singleton
{
    private static Singleton? instance;

    // Private constructor to prevent instantiation
    private Singleton()
    {
        Console.WriteLine("✅ Singleton instance created.");
    }

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }

    public void ShowMessage()
    {
        Console.WriteLine("📢 Hello from Singleton instance.");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("📘 Assignment 1: Singleton Pattern\n");

        // Get the singleton instance
        Singleton s1 = Singleton.GetInstance();
        s1.ShowMessage();

        // Try to get another instance
        Singleton s2 = Singleton.GetInstance();
        s2.ShowMessage();

        // Check if both are the same
        Console.WriteLine($"\nAre both instances same? {(Object.ReferenceEquals(s1, s2) ? "✅ Yes" : "❌ No")}");
    }
}

