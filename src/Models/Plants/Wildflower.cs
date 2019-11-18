using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IResource, IComposting
    {
        private int _compostProduced = 30;
        public string Type { get; } = "Wildflower";

        public double Compost()
        {
            return _compostProduced;
        }


        public override string ToString () {
            return $"Wildflower. Gorgeous!";
        }
    }
}