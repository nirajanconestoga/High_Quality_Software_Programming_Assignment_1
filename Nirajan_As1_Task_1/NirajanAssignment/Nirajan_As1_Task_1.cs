namespace Trip
{
    class Trips
    {
        const int calgaryPrice = 1350;
        const int vancouverPrice = 1500;
        const int montrealPrice = 575;
        // Enums for all trip prices
        enum TripPrice
        {
            Calgary = calgaryPrice * 2,
            Vancouver = vancouverPrice * 2,
            Montreal = montrealPrice * 2
        }
        static void Main()
        {
            // Variables to store trip counts and costs
            int tripsCalgary = 0, tripsVancouver = 0, tripsMontreal = 0;
            int totalCalgaryCost = 0, totalVancouverCost = 0, totalMontrealCost = 0;
            int totalTrips = 0, totalCost = 0;

            // Get the number of trips to Calgary
            try
            {
                Console.Write("Trips to Calgary: ");
                tripsCalgary = int.Parse(Console.ReadLine());
                if (tripsCalgary < 0)
                {
                    Console.WriteLine("No acceptable value for Calgary trips.");
                    Console.ReadLine();
                    return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.ReadLine();
                return;
            }

            // Get the number of trips to Vancouver
            try
            {
                Console.Write("Trips to Vancouver: ");
                tripsVancouver = int.Parse(Console.ReadLine());
                if (tripsVancouver < 0)
                {
                    Console.WriteLine("No acceptable value for Vancouver trips.");
                    Console.ReadLine();
                    return;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.ReadLine();
                return;
            }

            // Get the number of trips to Montreal
            try
            {
                Console.Write("Trips to Montreal: ");
                tripsMontreal = Convert.ToInt32(Console.ReadLine());
                if (tripsMontreal < 0)
                {
                    Console.WriteLine("No acceptable value for Montreal trips.");
                    Console.ReadLine();
                    return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.ReadLine();
                return;
            }

            // Total trips made by Carlo
            totalTrips = tripsCalgary + tripsVancouver + tripsMontreal;
            Console.WriteLine("The total trips made by Carlo is " + totalTrips);

            // Total Cost in Calgary, Vancouver and Montreal
            totalCalgaryCost = (tripsCalgary * (int)TripPrice.Calgary);
            totalVancouverCost = (tripsVancouver * (int)TripPrice.Vancouver);
            totalMontrealCost = (tripsMontreal * (int)TripPrice.Montreal);

            Console.WriteLine("Total expenses in Calgary is $" + totalCalgaryCost);
            Console.WriteLine("Total expenses in Vancouver is $" + totalVancouverCost);
            Console.WriteLine("Total expenses in Montreal is $" + totalMontrealCost);

            // Calculate total trips and expenses
            totalCost = totalCalgaryCost + totalVancouverCost + totalMontrealCost;
            Console.WriteLine("Total trip cost of Carlo is $" + totalCost);

            // Calculate and display average price per trip
            if (totalTrips > 0)
            {
                double averagePrice = totalCost / totalTrips;
                Console.WriteLine("The average price per trip is $" + averagePrice);
            }
            else
            {
                Console.WriteLine("No trips were made, so the average cost per trip cannot be calculated.");
            }
            Console.ReadLine();
        }
    }
}