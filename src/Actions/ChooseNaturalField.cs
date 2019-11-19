using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

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
                Console.WriteLine($"{i + 1}. Natural Field has {farm.NaturalFields[i]._seeds.Count} Plants");

                   var seedreport = from naturalseeds in farm.NaturalFields[i]._seeds
                                   group naturalseeds by naturalseeds.Type into seedgroup
                                   select  new Dictionary<string, int>(){
                {seedgroup.Key, seedgroup.Count()}};


              foreach(Dictionary<string,int> naturalseeds in seedreport){
    foreach(KeyValuePair<string,int> seedgroup in naturalseeds){
        Console.WriteLine($"This field has {seedgroup.Value} {seedgroup.Key}s");
        }
    };
}
Console.WriteLine($"Place the Seed Where?");
Console.WriteLine("> ");
int choice = Int32.Parse(Console.ReadLine());
farm.NaturalFields[choice -1].AddResource(seed);
    }}}