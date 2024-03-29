using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Duck : IResource, IMeatProducing
    {
               private Guid _id = Guid.NewGuid();
        private double _meatProduced = 1.1;
    private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public string Type {get; set;} = "Duck";

        public double Butcher()
        {
             return _meatProduced;
        }

        public override string ToString () {
            return $"Duck {this._shortId}. quack!";
        }
    }
}