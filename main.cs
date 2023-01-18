// Created by: Ekaterina
// Created on: Jan 2023
//
// This program calculates pi

using System;

class Program
{
    public static void Main(string[] args)
    {
        int numberOfLoops;
        int counter = 0;
        double denominator = -1;
        double pii = 0;

        Console.WriteLine(" ");
        Console.WriteLine("How accurate do you want PI?");
        Console.WriteLine(" ");
        Console.WriteLine("(The bigger your number, the more accurate it will be)");
        Console.WriteLine(" ");

        numberOfLoops = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");


        while (counter < numberOfLoops)
        {
            double numerator = 4;
            denominator = denominator + 2;
            double multiply = Math.Pow(-1, counter);
            double aLittleBit = (numerator / denominator) * multiply;
            pii = pii + aLittleBit;
            counter++;
        }
        Console.Clear();
        Console.WriteLine("Your PI is: " + pii.ToString("0.00"));
        Console.WriteLine("\nDone.");
    }
}