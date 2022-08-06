using System;
using trestleBridge.Models.Facilities;

namespace trestleBridge.Actions
{
    public class CreateFacility
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine ("1. Grazing field");
            Console.WriteLine ("2. Plowed field");
            Console.WriteLine ("3. Natural field");
            Console.WriteLine ("4. Chicken House");
            Console.WriteLine ("5. Duck House");
            Console.WriteLine ("Choose what you want to create");
            Console.Write ("> ");
            string input = Console.ReadLine ();
            Console.Clear();
            switch (Int32.Parse(input))
            {
                case 1:
                    farm.AddGrazingField(new GrazingField());
                    break;
                case 2:
                    farm.AddPlowedField(new PlowedField());
                    break;
                case 3: 
                    farm.AddNaturalField(new NaturalField());
                    break;
                case 4: 
                    farm.AddChickenHouse(new ChickenHouse());
                    break;
                case 5: 
                    farm.AddDuckHosue(new DuckHouse());
                    break;

                default:
                    Console.WriteLine("Please Enter A Valid Option");
                    break;
            }
        }
    }
}

