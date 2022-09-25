using Microsoft.VisualBasic;
using System;

namespace floorSpaceCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            // trying if statement for bool 
            Console.WriteLine("Which form has your room? Answer with Triangle, Rectangular or Non-rectangular");
            string answer1 = Console.ReadLine();
            if (answer1 == "rectangular")
            {
                Console.WriteLine("Enter floor width in meters:");
                decimal floorWidth = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter floor length in meters:");
                decimal floorLength = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter floor price per sqm:");
                decimal floorPrice = Convert.ToDecimal(Console.ReadLine());

                decimal floorAmount = ((decimal)floorWidth * (decimal)floorLength);

                decimal floorTotal = ((decimal)floorAmount * (decimal)floorPrice);

                decimal flooringTime = (decimal)floorAmount / 1.85806M;

                decimal flooringWorkCost = (decimal)flooringTime * 86;

                Console.WriteLine($"Floor area is: {floorAmount} and \nthe price for the floor is: {floorTotal}EUR. It will take {flooringTime} hours to put the floor and the total cost for work will be {flooringWorkCost}EUR");
            }

            else if (answer1 == "triangle")
            {
                Console.WriteLine("Enter floor length a in meters:");
                decimal floorLengthA = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter floor length b in meters:");
                decimal floorLengthB = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter floor length c in meters:");
                decimal floorLengthC = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter floor price per sqm:");
                decimal floorPrice = Convert.ToDecimal(Console.ReadLine());
                
                decimal floorHalfPerimeter = ((decimal)floorLengthA + (decimal)floorLengthB + (decimal)floorLengthC) / 2;

                decimal floorExtra = floorHalfPerimeter * ((floorHalfPerimeter - floorLengthA) + (floorHalfPerimeter - floorLengthB) + (floorHalfPerimeter - floorLengthC));

                double floorArea = Math.Sqrt((double)floorExtra);

                decimal floorTotal = ((decimal)floorArea * (decimal)floorPrice);

                decimal flooringTime = (decimal)floorArea / 1.85806M;

                decimal flooringWorkCost = (decimal)flooringTime * 86;

                Console.WriteLine($"Floor area is: {floorArea} and \nthe price for the floor is: {floorTotal}EUR. It will take {flooringTime} hours to put the floor and the total cost for work will be {flooringWorkCost}EUR");
            }

            else if (answer1 == "non-rectangular")
            {
                Console.WriteLine("Enter floor length a in meters:");
                decimal floorLengthA = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter floor length b in meters:");
                decimal floorLengthB = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter floor height in meters (height is the length from a to b and has 90 degrees corner with the length b or a:");
                decimal floorLengthH = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter floor price per sqm:");
                decimal floorPrice = Convert.ToDecimal(Console.ReadLine());

                decimal floorArea = (decimal)floorLengthH * ((decimal)floorLengthA + (decimal)floorLengthB);

                decimal floorTotal = ((decimal)floorArea * (decimal)floorPrice);

                decimal flooringTime = (decimal)floorArea / 1.85806M;

                decimal flooringWorkCost = (decimal)flooringTime * 86;                

                Console.WriteLine($"Floor area is: {floorArea} and \nthe price for the floor is: {floorTotal}EUR. It will take {flooringTime} hours to put the floor and the total cost for work will be {flooringWorkCost}EUR");

            }
        }
    }
}