using trestleBridge.Interfaces;
using trestleBridge.Models.Animals;

namespace trestleBridge.Actions
{
    public class ChooseChickenHouse
    {
        public ChooseChickenHouse()
        {

        }

        static void CollectInput(Farm farm, IGrazing animal)
        {
            // Console.Clear();
            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Grazing Field");
            }
            Console.WriteLine();
            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place {animal.Type.ToLower()} where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            farm.GrazingFields[choice].AddResource(animal);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);
        }

        internal static void CollectInput(Farm farm, Chicken chicken)
        {
            throw new NotImplementedException();
        }
    }
}

