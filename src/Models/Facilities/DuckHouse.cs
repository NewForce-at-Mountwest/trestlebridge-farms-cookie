using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class DuckHouse : IFacility<IMeatProducing>
    {
        // set capacity for duck house
        private int _capacity = 12;
        // create unique id for each duck house
        private Guid _id = Guid.NewGuid();

// build a list for animals in the duck house
        private List<IMeatProducing> _animals = new List<IMeatProducing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public string Message { get;}

        public void AddResource (IMeatProducing animal){
        if(this.Capacity > this._animals.Count)
        {
             _animals.Add(animal);
        }else{

    Console.WriteLine("that duckhouse is full");
    Console.WriteLine("Press enter to return to main menu");
    Console.ReadLine();
        }}

        public void AddResource (List<IMeatProducing> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"This duck house {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}