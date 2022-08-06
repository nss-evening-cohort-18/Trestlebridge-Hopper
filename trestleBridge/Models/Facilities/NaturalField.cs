using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Facilities
{
    public class NaturalField : IFacility<IPlant>
    {
        private int _capacity = 60;
        private Guid _id = Guid.NewGuid();

        private List<IPlant> _plants = new List<IPlant>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IPlant plant)
        {
            _plants.Add(plant);
        }

        public void AddResource(List<IPlant> plants)
        {
            plants.ForEach(x => _plants.Add(x));
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append($"Natural Field {shortId} has {this._plants.Count} plants\n");
            this._plants.ForEach(a => output.Append($"   {a}\n"));
            return output.ToString();
        }
    }
}
