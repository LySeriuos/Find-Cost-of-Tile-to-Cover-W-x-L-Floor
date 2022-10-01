using Microsoft.VisualBasic;
using System;

namespace floorSpaceCounter
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Which form has your room? Write 1 if Triangle, 2 if Rectangular or 3 if Non-rectangular");

                // changed answerUserInput to answerUserInput

                string answerUserInput = Console.ReadLine();
                const decimal COST_TILE = 86;
                const decimal AREA_PER_HOUR = 1.85806M;

                // changed "if else" to "if"

                if (answerUserInput == "2") // Rectangular

                    Console.WriteLine("Enter floor width in meters:");
                    decimal floorWidth = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Enter floor length in meters:");
                    decimal floorLength = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Enter floor price per sqm:");
                    decimal floorPrice = Convert.ToDecimal(Console.ReadLine());

                    // removed "(decimal)" before variables

                    decimal floorArea = floorWidth * floorLength;



                if (answerUserInput == "1") // Triangle

                    Console.WriteLine("Enter floor length a in meters:");
                    decimal floorLengthA = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Enter floor length b in meters:");
                    decimal floorLengthB = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Enter floor length c in meters:");
                    decimal floorLengthC = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Enter floor price per sqm:");
                    decimal floorPrice = Convert.ToDecimal(Console.ReadLine());

                    decimal floorHalfPerimeter = (floorLengthA + floorLengthB + floorLengthC) / 2;

                    decimal floorExtra = floorHalfPerimeter * ((floorHalfPerimeter - floorLengthA) + (floorHalfPerimeter - floorLengthB) + (floorHalfPerimeter - floorLengthC));

                    double floorAreaToConvert = Math.Sqrt((double)floorExtra);

                    // converting numbers from double to decimal

                    decimal floorArea = (decimal)floorAreaToConvert;


                if (answerUserInput == "3") // Non-rectangular

                    Console.WriteLine("Enter floor length a in meters:");
                    decimal floorLengthA = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Enter floor length b in meters:");
                    decimal floorLengthB = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Enter floor height in meters (height is the length from a to b and has 90 degrees corner with the length b or a:");
                    decimal floorLengthH = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Enter floor price per sqm:");
                    decimal floorPrice = Convert.ToDecimal(Console.ReadLine());

                    decimal floorArea = floorLengthH * (floorLengthA + floorLengthB);



                decimal floorTotal = floorArea * floorPrice;

                string roundedNumber = floorTotal.ToString("0.00");

                // converting numbers from double to decimal

                decimal flooringTime = floorArea / AREA_PER_HOUR;

                string roundedFlooringTime = flooringTime.ToString("0.00");

                decimal flooringWorkCost = flooringTime * COST_TILE;

                string roundedWorkCost = flooringWorkCost.ToString("0.00");

                Console.WriteLine($"Floor area is: {floorArea} and \nthe price for the floor is: {roundedNumber}EUR. \nIt will take {roundedFlooringTime} hours to put the floor and the total cost for work will be {roundedWorkCost}EUR");
            }

        }
}
