using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Facilities
{
    public class DuckHouse : IFacility<IFowl>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();

        private List<IFowl> _animals = new List<IFowl>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IFowl animal)
        {
            _animals.Add(animal);
        }

        public void AddResource(List<IFowl> animals)
        {
            animals.ForEach(x => _animals.Add(x));
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append($"Duck House {shortId} ({this._animals.Count} {(_animals.Count() == 1 ? "Duck" : "Ducks")})\n");
           // this._animals.ForEach(a => output.Append($"   {a}\n"));
            return output.ToString();
        }
    }
}
