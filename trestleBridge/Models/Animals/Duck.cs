using trestleBridge.Interfaces;

namespace trestleBridge.Models.Animals
{
    public class Duck : IResource, IFowl, IMeatProducing
    {
        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 2.6;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public double GrassPerDay { get; set; } = 2.3;
        public string Type { get; } = "Duck";

        // Methods
        public void Graze()
        {
            Console.WriteLine($"Duck {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        public double Butcher()
        {
            return _meatProduced;
        }

        public override string ToString()
        {
            return $"Duck {this._shortId}. Quack!";
        }
    }
}
