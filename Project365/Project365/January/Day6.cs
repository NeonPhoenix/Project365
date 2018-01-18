using System;

namespace Project365.January
{
    class Day6
    {
        public static void main()
        {
            Console.Clear();

            Console.WriteLine("Calculate total cost of tile required to cover W x L floor with tiles.");
            Console.WriteLine("Measurements should be in meters.");

            Console.Write("Width of the room: ");
            double roomWidth = double.Parse(Console.ReadLine());

            Console.Write("Length of the room: ");
            double roomLength = double.Parse(Console.ReadLine());

            Console.Write("Width of door to room: ");
            double doorWidth = double.Parse(Console.ReadLine());

            Console.Write("Width of the tile: ");
            double tileWidth = double.Parse(Console.ReadLine());

            Console.Write("Length of the tile: ");
            double tileLength = double.Parse(Console.ReadLine());

            Console.Write("Cost per tile: ");
            double tileCost = double.Parse(Console.ReadLine());

            //Calculate total area to cover
            double area = roomWidth * roomLength;
            double perimeter = (roomWidth + roomLength + roomWidth + roomLength) - doorWidth;
            double skirtingArea = perimeter * 0.1016; //skirting tile height is assumed 0.1016m
            double totalCoverArea = area + skirtingArea;

            //Calculate total area of tile
            double tileArea = tileWidth * tileLength;

            //Calculate total amount of tiles required. 5% has been added as wastage
            double totalTiles = totalCoverArea / tileArea;
            double totalTilesWastage = totalTiles * 0.05;
            double totalTilesPlusWaste = totalTiles + totalTilesWastage;
            double totalTilesRounded = Math.Ceiling(totalTilesPlusWaste);

            //Calculate total cost of all tiles required
            double totalCost = totalTilesRounded * tileCost;

            Console.WriteLine("Total cost for room of {0} Width and {1} Length is ${2} for a total of {3}.", roomWidth, roomLength, totalCost, totalTilesRounded);

            Program.Restart();
        }
    }
}
