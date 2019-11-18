using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class ChickenHouse : IFacility<IMeatProducing>
    {
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid();

        private List<IMeatProducing> _animals = new List<IMeatProducing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddResource (IMeatProducing animal){
        if(this.Capacity > this._animals.Count)
        {
             _animals.Add(animal);
        }else{

    Console.WriteLine("that Chicken Coop is full");
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

            output.Append($"This chicken house {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}