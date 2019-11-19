using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    // create class for wildflower
    public class Wildflower : IResource, IComposting
    {
        // set compost volume
        private int _compostProduced = 30;
        public string Type { get; } = "Wildflower";
// method to compost wildflowers
        public double Compost()
        {
            return _compostProduced;
        }

// message to display on farm report
        public override string ToString () {
            return $"Wildflower. Gorgeous!";
        }
    }
}