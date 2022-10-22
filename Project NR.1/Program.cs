
namespace floorSpaceCounter
{       // Program number 1
    class Program
    {
        static void Main(string[] args)
        {
            int inputChoise; // declare variables only for the if statements
            decimal floorArea;            

            while (true) // the program looping until it gets valid user input, then jumps to IF scopes
                {
                    Console.WriteLine("Which form has your room? Write 1 if Rectangular, 2 if Triangle or 3 if Non-rectangular");
                    string answerUserInput = Console.ReadLine(); // changed to answerUserInput
                    inputChoise = Convert.ToInt32(answerUserInput);
                    floorArea = 0; // Added this variable just to avoid error at the bottom from floorArea
                    if (inputChoise !=0 && inputChoise < 4) // valid input must be in between 0 and 4
                        break; //if it is valid it jumps further
                    Console.WriteLine("You entered a wrong number, please try again!"); //looping until user Input is valid
                }

            const decimal COST_TILE = 86; // price for putting floors per hour
            const decimal AREA_PER_HOUR = 1.85806M; // number to show how much sqm can be don in one hour

            if (inputChoise == 1) // Rectangular
            {
                Console.WriteLine("Enter floor width in meters:");
                decimal floorWidth = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter floor length in meters:");
                decimal floorLength = Convert.ToDecimal(Console.ReadLine());
                floorArea = floorWidth * floorLength; // counting the floor area in sqm                 
            }

            else if (inputChoise == 2) // Triangle
            {
                Console.WriteLine("Enter floor length a in meters:");
                decimal floorLengthA = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter floor length b in meters:");
                decimal floorLengthB = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter floor length c in meters:");
                decimal floorLengthC = Convert.ToDecimal(Console.ReadLine());

                decimal floorHalfPerimeter = (floorLengthA + floorLengthB + floorLengthC) / 2;
                decimal floorExtra = floorHalfPerimeter * ((floorHalfPerimeter - floorLengthA) + (floorHalfPerimeter - floorLengthB) + (floorHalfPerimeter - floorLengthC));
                double floorAreaSqrt = Math.Sqrt((double)floorExtra);
                floorArea = (decimal)floorAreaSqrt;                
            }
            
            else if (inputChoise == 3) // Non-rectangular
            {
                Console.WriteLine("Enter floor length a in meters:");
                decimal floorLengthA = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter floor length b in meters:");
                decimal floorLengthB = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter floor height in meters (height is the length from a to b and has 90 degrees corner with the length b or a:");
                decimal floorLengthH = Convert.ToDecimal(Console.ReadLine());

                floorArea = floorLengthH * (floorLengthA + floorLengthB);                
            }            
                    
            Console.WriteLine("Enter floor price per sqm:");
            decimal floorPrice = Convert.ToDecimal(Console.ReadLine());
            // initializing variables after the function to be used only if one of the "If" scopes were activated
            decimal floorTotal = floorArea * floorPrice;  // counting price for the tiles or other material
            decimal flooringTime = floorArea / AREA_PER_HOUR; // counting how much time it will be needed to put floor
            decimal flooringWorkCost = flooringTime * COST_TILE; // counting the price for the work 
            decimal totalPrice = flooringWorkCost + floorTotal; // total price for the whole project

            Console.WriteLine($"Floor area is: {floorArea} sqm. \nThe price for the floor is: {floorTotal:0.00}EUR. \nIt will take {flooringTime:0.00} hours to put the floor. \nThe total cost for work will be {flooringWorkCost:0.00}EUR.\nTotal price: {totalPrice:0.00}EUR ");
        }
    }
}