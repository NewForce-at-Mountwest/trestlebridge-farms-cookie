using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChoosePlantingField
    {
        // Have user select which field they would like to plant in and direct to that list

        public static void CollectInput(Farm farm, Sunflower sunflower)
        {
            Console.WriteLine("Where would you like to plant these seeds?");
            Console.WriteLine("1. Natural Field");
            Console.WriteLine("2. Plowed Field");
            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (Int32.Parse(choice))
            {
                case 1:
                    ChooseNaturalField.CollectInput(farm, sunflower);
                    break;
                case 2:
                    ChoosePlowedField.CollectInput(farm, sunflower);
                    break;
                default:
                    break;
            }
        }
    }
}
