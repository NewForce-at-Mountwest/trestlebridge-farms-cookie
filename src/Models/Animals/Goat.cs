using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Goat : IResource, IGrazing, IMeatProducing {

    // *** Creates unique ID
        private Guid _id = Guid.NewGuid();

    // *** Sets amount of meat that is produced.
        private double _meatProduced = 7.5;

    // *** Retrieves shortId
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

    // *** Getter / Setter properties: amount of feed and type of animal

        public double GrassPerDay { get; set; } = 4.1;
        public string Type { get; set; } = "Goat";
      
    // *** Method: Displays how much feed animal consumes
        public void Graze () {
            Console.WriteLine($"Goat {this._shortId} just ate {this.GrassPerDay}kg of compost.");
        }
    // *** Method: Returns the amount of meat produced.
        public double Butcher () {
            return _meatProduced;
        }

    // *** Method: Confirmation output after animal is purchased.
        public override string ToString () {
            return $"Goat {this._shortId}. *screams*";
        }
    }
}