using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        // Lists of facilities on the Farm
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<PlantingField> PlantingFields { get; } = new List<PlantingField>();
        public List<NaturalField> NaturalFields {get;}=new List<NaturalField>();
        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();
        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();

        public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T>(IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                    case "Ostrich":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                default:
                    break;

                     case "Goat":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;

                     case "Sheep":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;


            }
        }

        public void AddGrazingField(GrazingField field)
        {
            GrazingFields.Add(field);

        }
        public void AddPlowedField (PlowedField field){
            PlowedFields.Add(field);
        }
        public void AddNaturalField (NaturalField field){
            NaturalFields.Add(field);
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));
            PlowedFields.ForEach(pf => report.Append(pf));
            NaturalFields.ForEach(nf=> report.Append(nf));
            ChickenHouses.ForEach(ch => report.Append(ch));
            DuckHouses.ForEach(dh => report.Append(dh));
            return report.ToString();
        }















// method to add chcicken house to the list of chicken houses in farm
        public void AddChickenHouse(ChickenHouse house)
        {
            ChickenHouses.Add(house);
        }

// method to add duck house to the list of duck houses in farm
        public void AddDuckHouse(DuckHouse house)
        {
            DuckHouses.Add(house);
        }

    }
}