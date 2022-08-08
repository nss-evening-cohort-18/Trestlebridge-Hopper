using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Facilities
{
    public class NaturalField : IFacility<IFlower>
    {
        private int _rowCapacity = 10;
        private int _plantPerRow = 6;
        private Guid _id = Guid.NewGuid();

        private List<IFlower> _plants = new List<IFlower>();

        public double Capacity
        {
            get
            {
                return _rowCapacity;
            }
        }

        public double CurrectCount
        {
            get
            {
                return _plants.Count();
            }
        }

        public void AddResource(IFlower plant)
        {
            _plants.Add(plant);
        }

        public void AddResource(List<IFlower> plants)
        {
            plants.ForEach(x => _plants.Add(x));
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append($"Natural Field {shortId} has {this._plants.Count} rows of plants\n");
            //this._plants.ForEach(a => output.Append($"   {a}\n"));
            return output.ToString();
        }
    }
}
