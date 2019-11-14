using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChoosePlantingField
    {
        public static void CollectInput(Farm farm, ISeedProducing seed)
        {
            Utils.Clear();

            for (int i = 0; i < farm.PlantingFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Planting Field");
            }

            Console.WriteLine();

            // Message to choose correct planting field
            Console.WriteLine($"Plant the seeds where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            farm.PlantingFields[choice].AddResource(seed);


        }
    }
}