using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Actions
{
    public class ChooseNaturalField
    {
        // Constructors
        public ChooseNaturalField()
        {

        }

        // Fields

        // Properties

        // Methods
        public static void CollectInput(Farm farm, IFlower flower)
        {
            // Console.Clear();
            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Natural Field ({farm.NaturalFields[i].CurrectCount} rows of plants)");
            }
            Console.WriteLine();
            // How can I output the type of plant chosen here?
            Console.WriteLine($"Plant {flower.Type.ToLower()} where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            if(farm.NaturalFields[choice - 1].CurrectCount < farm.NaturalFields[choice - 1].Capacity)
            {
                farm.NaturalFields[choice - 1].AddResource(flower);
                Console.Clear();
            } else
            {
                ChooseNaturalField.CapacityCheck(farm, flower);
            }

            

        }

        public static void CapacityCheck(Farm farm, IFlower flower)
        {
            Console.Clear();
            Console.WriteLine("**** That facility is not large enough ****");
            Console.WriteLine("****     Please choose another one     ****");
            Console.WriteLine();
            ChooseNaturalField.CollectInput(farm, flower);
        }
    }
}
