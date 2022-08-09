using trestleBridge.Interfaces;


namespace trestleBridge.Actions
{
    public class ChooseChickenHouse
    {
        public ChooseChickenHouse()
        {

        }

        public static void CollectInput(Farm farm, IFowl animal)
        {
            // Console.Clear();
            for (int i = 0; i < farm.ChickenHouses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Chicken House");
            }
            Console.WriteLine();
            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place {animal.Type.ToLower()} where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            farm.ChickenHouses[choice - 1].AddResource(animal);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);
        }


    }
}

