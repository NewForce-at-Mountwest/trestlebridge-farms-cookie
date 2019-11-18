using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (IGrazing animal){
        if(this.Capacity > this._animals.Count)
        {
             _animals.Add(animal);
        }else{

    Console.WriteLine("that grazingfield is full");
    Console.WriteLine("Press enter to return to main menu");
    Console.ReadLine();
        }}

        public void AddResource (List<IGrazing> animals)
        {
            // TODO: implement this...
            animals.ForEach(animal=> _animals.Add(animal));
          Console.WriteLine($"The {animals} have been put in the field");
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}