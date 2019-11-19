using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChoosePlowedField
    {
        // loop through the natural fields and list options for fields to plant
        public static void CollectInput(Farm farm, ISeedProducing seed)
        {
 Utils.Clear();
            for (int i = 0; i < farm.PlowedFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Plowed Field has {farm.PlowedFields[i]._seeds.Count} Plants");

                   var seedreport = from plowedseeds in farm.PlowedFields[i]._seeds
                                   group plowedseeds by plowedseeds.Type into seedgroup
                                   select  new Dictionary<string, int>(){
                {seedgroup.Key, seedgroup.Count()}};


              foreach(Dictionary<string,int> plowedseeds in seedreport){
    foreach(KeyValuePair<string,int> seedgroup in plowedseeds){
        Console.WriteLine($"This field has {seedgroup.Value} {seedgroup.Key}s");
        }
    };
}
Console.WriteLine($"Place the Seed Where?");
Console.WriteLine("> ");
int choice = Int32.Parse(Console.ReadLine());
farm.PlowedFields[choice -1].AddResource(seed);
    }}}