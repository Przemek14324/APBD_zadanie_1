﻿namespace Zadanie1;

public class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("hello world");
        Console.WriteLine("Goodbye world :(");
        int[] sampleNumbers = { 1, 2, 3, 4, 5 };
        double average = CalculateAverageZmiana(sampleNumbers);
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine("koniec zadan");
    }
    public static double CalculateAverageZmiana(int[] numbers)
    {
        return numbers.Average();
    }
    public static int CalculateMax(int[] numbers)
    {
        return numbers.Max();
    }
  

}
