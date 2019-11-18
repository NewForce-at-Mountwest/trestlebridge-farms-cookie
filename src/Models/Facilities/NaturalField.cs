using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class NaturalField : IFacility<ISeedProducing>
    {
        public string FieldCapacity {get;set;}
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid();

        private List<ISeedProducing> _seeds = new List<ISeedProducing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (ISeedProducing seed){
        if(this.Capacity > this._seeds.Count)
        {
             _seeds.Add(seed);
        }else{

    Console.WriteLine("that  Natura field is full");
    Console.WriteLine("Press enter to return to main menu");
    Console.ReadLine();
        }}

        public void AddResource (List<ISeedProducing> seed)
        {
            // TODO: implement this...

            seed.ForEach(seed=> _seeds.Add(seed));
          Console.WriteLine($"The {seed} have been put in the field");
        }

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