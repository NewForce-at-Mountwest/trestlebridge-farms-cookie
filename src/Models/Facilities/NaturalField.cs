using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    // create class for a a natural field
    public class NaturalField : IFacility<IComposting>
    {
        public string FieldCapacity { get; set; }
        private int _capacity = 2;
        private Guid _id = Guid.NewGuid();
        private List<IComposting> _seeds = new List<IComposting>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }
        // add seeds to list of plants on a field if there is capacity
        public void AddResource(IComposting seed)
        {
            if (this.Capacity > this._seeds.Count)
            {
                _seeds.Add(seed);
            }
            else
            {
                // error message if the field is at capacity
                Console.WriteLine("That Natural Field is full");
                Console.WriteLine("Press enter to return to main menu");
                Console.ReadLine();
            }
        }

        public void AddResource(List<IComposting> seed)
        {
            seed.ForEach(seed => _seeds.Add(seed));
            Console.WriteLine($"The {seed} have been put in the field");
        }
        // create string for natural fields on farm report
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Natural field {shortId} has {this._seeds.Count} seeds\n");
            this._seeds.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}