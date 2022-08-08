using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Actions
{
    public class ChoosePlowedField
    {
        // Constructors
        public ChoosePlowedField()
        {

        }

        // Fields

        // Properties

        // Methods
        public static void CollectInput(Farm farm, IFlower flower)
        {
            // Console.Clear();
            for (int i = 0; i < farm.PlowedFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Plowed Field ({farm.PlowedFields[i].CurrectCount} rows of plants)");
            }
            Console.WriteLine();
            // How can I output the type of plant chosen here?
            Console.WriteLine($"Plant {flower.Type.ToLower()} where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            if (farm.PlowedFields[choice - 1].CurrectCount < farm.PlowedFields[choice - 1].Capacity)
            {
                farm.PlowedFields[choice - 1].AddResource(flower);
                Console.Clear();
            }
            else
            {
                ChoosePlowedField.CapacityCheck(farm, flower);
            }
            

        }

        public static void CapacityCheck(Farm farm, IFlower flower)
        {
            Console.Clear();
            Console.WriteLine("**** That facility is not large enough ****");
            Console.WriteLine("****     Please choose another one     ****");
            Console.WriteLine();
            ChoosePlowedField.CollectInput(farm, flower);
        }


    }
}
