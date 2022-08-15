using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Equiptment
{
    public class FeatherHarvester : IEquipment
    {
        // Constructors

        // Fields

        // Properties
        public int ProcessingLimit { get; set; } = 8;
        public string Type { get; set; } = "Feather Harvester";

        // Methods
    }
}
