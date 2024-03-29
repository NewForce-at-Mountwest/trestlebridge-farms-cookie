using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    // create class for sesame seeds
    public class Sesame : IResource, ISeedProducing
    {
        private int _seedsProduced = 520;
        public string Type { get;set; } = "Sesame";

        public double Harvest () {
            return _seedsProduced;
        }

        public override string ToString () {
            return $"Sesame. Yum!";
        }
    }
}