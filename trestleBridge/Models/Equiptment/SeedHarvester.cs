using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Equiptment
{
    public class SeedHarvester : IEquipment
    {
        // Constructors

        // Fields

        // Properties
        public int ProcessingLimit { get; set; } = 5; 
        public string Type { get; set; } = "Seed Harvester";

        // Methods
    }
}
