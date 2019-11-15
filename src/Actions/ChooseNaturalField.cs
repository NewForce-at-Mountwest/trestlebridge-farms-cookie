using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseNaturalField
    {
        public static void CollectInput(Farm farm, ISeedProducing seed)
        {
            Utils.Clear();

            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Natural Field");
            }
            // Why are they using a JS style for loop

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Plant the seed where?");
            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Natural Field");
            }

            Console.WriteLine();

            // Message to choose correct planting field
            Console.WriteLine($"Plant the seeds where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            farm.NaturalFields[choice].AddResource(seed);
            // add list of current options

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);
            farm.NaturalFields[choice].AddResource(seed);


        }
    }
}