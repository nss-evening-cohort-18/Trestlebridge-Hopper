using trestleBridge.Interfaces;

namespace trestleBridge.Models.Flowers
{
    public class Sesame : IFlower
    {
        // Constructors

        // Fields
        private Guid _id = Guid.NewGuid();
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        // Properties

        public string Type { get; } = "Sesame";
        public int SeedsProduced { get; } = 520;

        // Methods
    }
}
