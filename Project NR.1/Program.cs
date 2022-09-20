using Microsoft.VisualBasic;
using System;

namespace floorSpaceCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter floors width in meters:");
            decimal floorWidth = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter floors length in meters:");
            decimal floorLength = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter floors price per sqm:");
            decimal floorPrice = Convert.ToDecimal(Console.ReadLine());

            decimal floorAmount = ((decimal)floorWidth * (decimal)floorLength);

            decimal floorTotal = ((decimal)floorAmount * (decimal)floorPrice);

            Console.WriteLine($"Floor area is: {floorAmount} and \nthe price for the floor is: {floorTotal}EUR");
        }
    }
}