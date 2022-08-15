using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Equiptment
{
    public class Composter : IEquipment
    {
        // Constructors

        // Fields

        // Properties
        public int ProcessingLimit { get; set; } = 8;
        public string Type { get; set; } = "Composter";

        // Methods
    }
}
