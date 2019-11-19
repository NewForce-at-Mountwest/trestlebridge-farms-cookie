using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Utils.Clear();
            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Grazing Field has {farm.GrazingFields[i]._animals.Count} grazing animals");
                   var ostrichreport = from grazinganimal in farm.GrazingFields[i]._animals
                                   group grazinganimal by grazinganimal.Type into animalgroup
                                   select  new Dictionary<string, int>(){
                {animalgroup.Key, animalgroup.Count()}};
              Console.WriteLine();
            };



        // To show the number of grazing fields

        Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

        farm.GrazingFields[choice - 1].AddResource(animal);

        /*

            // foreach (IGrazing grazingAnimal in farm.GrazingFields[i]._animals)
            // {

            //     Console.WriteLine(grazingAnimal);
            // };
            Couldn't get this to work. Can you?
            Stretch goal. Only if the app is fully functional.
         */
        // farm.PurchaseResource<IGrazing>(animal, choice);

    }
}
}