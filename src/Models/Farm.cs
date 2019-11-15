using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();

        public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        //  Add stuff from facilities to list in farmstatus option
        public void PurchaseResource<T> (IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
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

                     case "Ostrich":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;

            }
        }

        public void AddGrazingField (GrazingField field)
        {
            GrazingFields.Add(field);

        }
        public void AddPlowedField (PlowedField field){
            PlowedFields.Add(field);
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));
            PlowedFields.ForEach(pf => report.Append(pf));

            return report.ToString();
        }
    }
}