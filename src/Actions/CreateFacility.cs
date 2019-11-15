using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class CreateFacility {
        public static void CollectInput (Farm farm) {
            Console.WriteLine ("1. Grazing field");
            Console.WriteLine ("2. Plowed field");
            // add other facility options and add classes to models

            Console.WriteLine ();
            // Need to set up a message to show created field
            Console.WriteLine ("Choose what you want to create");

            Console.Write ("> ");
            string input = Console.ReadLine ();

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
                    break;
                default:
                    break;
            }
        }
    }
}