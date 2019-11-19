using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Pig : IResource, IGrazing, IMeatProducing {

    // *** Creates unique ID
        private Guid _id = Guid.NewGuid();

    // *** Sets amount of meat that is produced.
        private double _meatProduced = 8.4;

    // *** Retrieves shortId
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

    // *** Getter / Setter properties: amount of feed and type of animal
        public double GrassPerDay { get; set; } = 5.4;
        public string Type { get; } = "Pig";
        string IGrazing.Type { get; set;}

    // *** Method: Displays how much feed animal consumes
        public void Graze () {
            Console.WriteLine($"Pig {this._shortId} just ate {this.GrassPerDay}kg of grass.");
        }
    // *** Method: Returns the amount of meat produced.
        public double Butcher () {
            return _meatProduced;
        }
    // *** Method: Confirmation output after animal is purchased.
        public override string ToString () {
            return $"Pig {this._shortId}. Oink Oink!";
        }
    }
}