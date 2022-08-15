using trestleBridge.Interfaces;
using trestleBridge.Models.Facilities;

namespace trestleBridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            // Console.Clear();
            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                if (farm.GrazingFields[i].CurrentCount < 20)
                {
                    Console.WriteLine($"{i + 1}. Grazing Field  ({farm.GrazingFields[i].CurrentCount} animals)");
                }
                else
                {
                    Console.WriteLine($@"****That facililty is not large enough * ***
                                         ****Please choose another one * ***");
                }
            }
            Console.WriteLine();
            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place {animal.Type.ToLower()} where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            farm.GrazingFields[choice - 1].AddResource(animal);
            Console.Clear();

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);
        }

        public static GrazingField ProcessingOptions(Farm farm)
        {
            for (int i = 0; i < farm.GrazingFields.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. Grazing Field ({farm.GrazingFields[i].CurrectCount} Animals)");
            }
            Console.WriteLine();
            Console.WriteLine("Which facility has the animals you want to process from?\n");
            Console.Write("> ");
            string option = Console.ReadLine();

            return farm.GrazingFields[Int32.Parse(option) - 1];
        }


    }
}

