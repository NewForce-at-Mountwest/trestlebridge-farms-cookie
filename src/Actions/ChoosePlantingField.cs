using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;

namespace Trestlebridge.Actions
{
    public class ChoosePlantingField
    {
        // Have user select which field they would like to plant in and direct to that list

        // conditional to choose correct field based on input of seed type
        public static void CollectInput(Farm farm, ISeedProducing seed)
        {
            Console.WriteLine("Where would you like to plant these seeds?");

            Console.WriteLine("1. Natural Field");
            Console.WriteLine("2. Plowed Field");
            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (Int32.Parse(choice))
            {
                case 1:
                    ChooseNaturalField.CollectInput(farm, seed);
                    break;
                case 2:
                    ChoosePlowedField.CollectInput(farm, seed);
                    break;
                default:
                    break;
            }
            Console.WriteLine();

        }
    }

}