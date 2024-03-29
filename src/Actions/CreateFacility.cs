using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class CreateFacility
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Grazing field");
            Console.WriteLine("2. Plowed field");
            Console.WriteLine("3. Natural Field");

            Console.WriteLine("4. Chicken house");
            Console.WriteLine("5. Duck house");

            Console.WriteLine();
            Console.WriteLine("Choose what you want to create");

            Console.Write("> ");
            string input = Console.ReadLine();
            // functions to create facilities with completion message
            switch (Int32.Parse(input))
            {
                case 1:
                    farm.AddGrazingField(new GrazingField());
                    Console.WriteLine("New Grazing Field Added");
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadLine();
                    break;

                case 2:
                    farm.AddPlowedField(new PlowedField());
                    Console.WriteLine("New Plowed Field Added");
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadLine();
                    break;

                case 3:
                    farm.AddNaturalField(new NaturalField());
                    Console.WriteLine("New Natural Field Added");
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadLine();
                    break;






                case 4:
                    farm.AddChickenHouse(new ChickenHouse());
                    Console.WriteLine("You have a new chicken house!");
                    Console.WriteLine("Hit any key to continue");
                    Console.ReadLine();
                    break;
                case 5:
                    farm.AddDuckHouse(new DuckHouse());
                    Console.WriteLine("You have a new duck house!");
                    Console.WriteLine("Hit any key to continue");
                    Console.ReadLine();

                    break;
                default:
                    break;
            }
        }
    }
}