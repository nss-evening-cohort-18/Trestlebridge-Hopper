using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Equiptment
{
    public class EggGatherer : IEquipment
    {
        // Constructors

        // Fields

        // Properties
        public int ProcessingLimit { get; set; } = 15;
        public string Type { get; set; } = "Egg Gatherer";

        // Methods
    }
}
