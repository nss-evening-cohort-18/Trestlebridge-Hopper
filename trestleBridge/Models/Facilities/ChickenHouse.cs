﻿using System.Text;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Facilities
{
    public class ChickenHouse : IFacility<IFowl>
    {
        private int _capacity = 15;
        private Guid _id = Guid.NewGuid();

        private List<IFowl> _animals = new List<IFowl>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public double CurrentCount
        {
            get { return _animals.Count(); }
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
            output.Append($"Chicken House {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));
            return output.ToString();
        }
    }
}
