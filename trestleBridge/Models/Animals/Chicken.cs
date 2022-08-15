using trestleBridge.Interfaces;

namespace trestleBridge.Models.Animals
{
    public class Chicken : IResource, IFowl, IMeatProducing
    {
        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 1.7;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public double GrassPerDay { get; set; } = 2.3;
        public string Type { get; } = "Chicken";

        // Methods

        public double Butcher()
        {
            return _meatProduced;
        }

        public override string ToString()
        {
            return $"Chicken {this._shortId}. Cluck!";
        }
    }
}
