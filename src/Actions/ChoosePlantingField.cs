using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChoosePlantingField
    {

        // conditional to choose correct field based on input of seed type
        public static void CollectInput(Farm farm, ISeedProducing seed)
        {
            Utils.Clear();

            for (int i = 0; i < farm.PlowedFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Plowed Field");
            }

            Console.WriteLine();


            // Message to choose correct planting field
            Console.WriteLine($"Plant the seeds where?");

            Console.Write("> ");
            // add conditional statement to add to correct field choice and capacity?

            int choice = Int32.Parse(Console.ReadLine());

            farm.PlowedFields[choice-1].AddResource(seed);

        }
    }
}