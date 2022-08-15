using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Models.Equiptment;

namespace trestleBridge.Actions
{
    public class ChooseEquipment
    {
        public static void EquipmentOption(Farm farm)
        {
            Console.WriteLine("1. Seed Harvester");
            Console.WriteLine("2. Meat Processor");
            Console.WriteLine("3. Egg Gatherer");
            Console.WriteLine("4. Composter");
            Console.WriteLine("5. Feather Harvester");
            Console.WriteLine();
            Console.WriteLine("Choose equipment to use.");
            Console.Write("> ");
            var option = Console.ReadLine();
            Console.WriteLine();

            if (option == "1")
            {
                
            }
            else if (option == "2")
            {
                MeatProcessor.Process(farm);
            }
            else if (option == "3")
            {
               
            }
            else if (option == "4")
            {
               
            }
            else if (option == "5")
            {
                
            }
            else
            {
                Console.WriteLine($"Invalid option: {option}");
            }
        }
    }
}
