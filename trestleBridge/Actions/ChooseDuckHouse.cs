using trestleBridge.Interfaces;

namespace trestleBridge.Actions
{
    public class ChooseDuckHouse
    {
        public ChooseDuckHouse()
        {

        }

        public static void CollectInput(Farm farm, IFowl animal)
        {
            // Console.Clear();
            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {
                if (farm.DuckHouses[i].CurrentCount < 12)
                {
                    Console.WriteLine($"{i + 1}. Duck House  ({farm.DuckHouses[i].CurrentCount} animals)");
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

            farm.DuckHouses[choice - 1].AddResource(animal);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);
        }


    }
}

