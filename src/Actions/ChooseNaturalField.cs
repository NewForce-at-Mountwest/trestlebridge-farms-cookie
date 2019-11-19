using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChooseNaturalField
    {
        // loop through the natural fields and list options for fields to plant
        public static void CollectInput(Farm farm, IComposting seed)
        {
            Utils.Clear();

            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Plowed Field {NaturalField._seeds.Count}");
            }

            Console.WriteLine();

            Console.Write("> ");
            // Collect response and add seed to the selected field

            int choice = Int32.Parse(Console.ReadLine());

            farm.NaturalFields[choice-1].AddResource(seed);

        }
    }
}