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
        public static void CollectInput(Farm farm, IResource resource)
        {
            Console.WriteLine("Where would you like to plant these seeds?");
            Console.WriteLine("2. Plowed Field");
            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (Int32.Parse(choice))
            {
                case 2:
                    ChoosePlowedField.CollectInput(farm, resource);
                    break;
                default:
                    break;
            }
            Console.WriteLine();

        }
         public static void CollectInput(Farm farm, IResource resource)
        {
            Console.WriteLine("Where would you like to plant these seeds?");
            Console.WriteLine("1. Natural Field");
            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (Int32.Parse(choice))
            {
                case 1:
                    ChooseNaturalField.CollectInput(farm, resource);
                    break;
                default:
                    break;
            }
            Console.WriteLine();

        }
        public static void CollectInput(Farm farm, IResource resource)
        {
            Console.WriteLine("Where would you like to plant these seeds?");
            Console.WriteLine("1. Natural Field");
            Console.WriteLine("2. Plowed Field");
            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (Int32.Parse(choice))
            {
                case 3:
                    ChooseNaturalField.CollectInput(farm resource);
                    break;
                default:
                    break;
            }
            Console.WriteLine();

        }
    }
}