using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Facilities
{
    public class PlowedField : IFacility<IFlower>
    {
        private int _rowCapacity = 13;
        private int _plantPerRow = 5;
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
            int count = 1;
            string stringReturn = "(";
            Dictionary<string, int> PlantRank = new();
            foreach (IFlower plant in _plants)
            {
                if (PlantRank.ContainsKey(plant.Type))
                {
                    PlantRank[plant.Type]++;
                }
                else
                {
                    PlantRank.Add(plant.Type, 1);
                }
            }
            PlantRank.OrderByDescending(x => x.Value);

            foreach (var plant in PlantRank)
            {
                if (count != PlantRank.Count)
                {
                    stringReturn += $"{plant.Key}: {plant.Value}, ";
                    count++;
                }
                else
                {
                    stringReturn += $"{plant.Key}: {plant.Value}";
                }
            }
            stringReturn += ")";

            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append($"Plowed Field {shortId} {(_plants.Count() == 0 ? "(0 plants)" : stringReturn)}\n");
            //this._plants.ForEach(a => output.Append($"   {a}\n"));
            return output.ToString();
        }
    }
}
