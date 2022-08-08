using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Flowers
{
    public class Wildflower : IFlower
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

        public string Type { get; } = "Wildflower";

        // Methods
    }
}
