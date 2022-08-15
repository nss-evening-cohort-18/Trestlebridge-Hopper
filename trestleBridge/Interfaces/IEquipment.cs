using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trestleBridge.Interfaces
{
    internal interface IEquipment
    {
        int ProcessingLimit { get; set; }
        string Type { get; set; }
    }
}
