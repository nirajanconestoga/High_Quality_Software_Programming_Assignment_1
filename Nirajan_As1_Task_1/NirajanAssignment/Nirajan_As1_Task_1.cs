namespace Trip
{
    class Trips
    {
        static void Main()
        {
            // Variables to store the prices for trips
            int priceCalgary = 1350 * 2;
            int priceVancouver = 1500 * 2;
            int priceMontreal = 575 * 2;

            // Variable to store the total number of trip
            int totalTrips = 0;

            // Variable to store the cost per state and total cost of the trips
            double totalCalgaryCost = 0;
            double totalVancouverCost = 0;
            double totalMontrealCost = 0;
            double totalCost = 0;


            // Get the number of trips to Calgary
            Console.Write("Trips to Calgary: ");
            int tripsCalgary = int.Parse(Console.ReadLine());
            if (tripsCalgary <= 0)
            {
                Console.WriteLine("No acceptable value");
                return;

            }
            //Total cost in the Calgary
            totalCalgaryCost += tripsCalgary * priceCalgary;
            Console.WriteLine("Total expenses in calgary is $" + totalCalgaryCost);

            // Get the number of trips to Vancouver
            Console.Write("Trips to Vancouver : ");
            int tripsVancouver = int.Parse(Console.ReadLine());
            if (tripsVancouver < 0)
            {
                Console.WriteLine("No acceptable value");
                return;
            }
            //Total cost in the Vancouver
            totalVancouverCost += tripsVancouver * priceVancouver;
            Console.WriteLine("Total expenses in Vancouver is $" + totalVancouverCost);

            // Get the number of trips to Montreal
            Console.Write("Trips to Montreal: ");
            int tripsMontreal = int.Parse(Console.ReadLine());
            if (tripsMontreal < 0)
            {
                Console.WriteLine("No acceptable value");
                return;
            }
            // Total cost in the Montreal
            totalMontrealCost += tripsMontreal * priceMontreal;
            Console.WriteLine("Total expenses in Montreal is $" + totalMontrealCost);

            // Get total trips made by Carlo
            totalTrips = tripsCalgary + tripsMontreal + tripsVancouver;
            Console.WriteLine("The total trips made by Carlo is " + totalTrips);

            // Get total expenses made by Carlo
            totalCost = totalCalgaryCost + totalVancouverCost + totalMontrealCost;  
            Console.WriteLine("Total trip cost of Carlo is $" + totalCost);

            // Get average price per trip
            double averagePrice = totalCost / totalTrips;
            Console.WriteLine("The average price per trip is $" + averagePrice);

            Console.ReadKey();
        }
    }
}

