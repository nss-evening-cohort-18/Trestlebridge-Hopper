using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Actions;
using trestleBridge.Interfaces;
using trestleBridge.Models.Facilities;

namespace trestleBridge.Models.Equiptment
{
    public class MeatProcessor : IEquipment
    {
        // Constructors

        // Fields

        // Properties
        public int ProcessingLimit { get; set; } = 7;
        public string Type { get; set; } = "Meat Processor";

        // Methods
        public static void Process(Farm farm)
        {
            Console.WriteLine("1. Grazing Fields");
            Console.WriteLine("2. Chicken Houses");
            Console.WriteLine("3. Exit to menu");
            Console.WriteLine();
            Console.WriteLine("Where would you like to harvest from?");
            Console.Write("> ");
            string option = Console.ReadLine();

            if(option == "1")
            {
                GrazingField fieldChoice = ChooseGrazingField.ProcessingOptions(farm);
                
            }
            else if(option == "2")
            {

            }
            else if(option == "3")
            {

            }
            else
            {
                Console.WriteLine("Invalid Option");
                return;
            }
        }
    }
}
