using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    // create class for sunflower
    public class Sunflower : IResource, ISeedProducing, IComposting
    {
        private int _seedsProduced = 650;
        private int _compostProduced = 21;
        public string Type { get; } = "Sunflower";
// method to compost plant
        public double Compost()
        {
            return _compostProduced;
        }
// method to harvest seeds
        public double Harvest () {
            return _seedsProduced;
        }
// string to read on farm report
        public override string ToString () {
            return $"Sunflower. Beautiful!";
        }
    }
}