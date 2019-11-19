using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IResource, ISeedProducing, IComposting
    {
        private int _seedsProduced = 650;
        private int _compostProduced = 21;
        public string Type { get; set; } = "Sunflower";

        public double Compost()
        {
            return _compostProduced;
        }

        public double Harvest () {
            return _seedsProduced;
        }

        public override string ToString () {
            return $"Sunflower. Beautiful!";
        }
    }
}