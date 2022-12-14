using System.Text;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Facilities
{
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 20;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

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

        public double CurrectCount
        {
            get
            {
                return _animals.Count();
            }
        }


        public void AddResource(IGrazing animal)
        {
            _animals.Add(animal);
        }

        public void AddResource(List<IGrazing> animals)
        {
            animals.ForEach(x => _animals.Add(x));
        }
        public override string ToString()
        {
            int count = 1;
            string stringReturn = "(";
            Dictionary<string, int> AnimalRank = new();
            foreach (IGrazing animal in _animals)
            {
                if (AnimalRank.ContainsKey(animal.Type))
                {
                    AnimalRank[animal.Type]++;
                } else
                {
                    AnimalRank.Add(animal.Type, 1);
                }
            }
            AnimalRank.OrderByDescending(x => x.Value);
            
            foreach (var animal in AnimalRank)
            {
                if(count != AnimalRank.Count)
                {
                stringReturn += $"{animal.Key}: {animal.Value}, ";
                    count++;
                } else
                {
                    stringReturn += $"{animal.Key}: {animal.Value}";
                }
            }
            stringReturn += ")";

            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append($"Grazing field {shortId} {(_animals.Count() == 0 ? "(0 animals)" : stringReturn)}\n");
            //this._animals.ForEach(a => output.Append($"   {a}\n"));
            return output.ToString();
        }
    }
}
