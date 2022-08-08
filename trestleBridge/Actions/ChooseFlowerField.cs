using trestleBridge.Interfaces;

namespace trestleBridge.Actions
{
    public class ChooseFlowerField
    {
        // Constructors

        // Fields

        // Properties

        // Methods
        public static void CollectInput(Farm farm, IFlower flower)
        {
            //Console.Clear();
            Console.WriteLine("What type of field do you want to plant the seed in?");
            Console.WriteLine("1. Plowed Field");
            Console.WriteLine("2. Natural Field");
            Console.WriteLine("3. Return to main menu");
            Console.Write(">");
            int fieldChoice = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            if (fieldChoice == 1)
            {
                for (int i = 0; i < farm.PlowedFields.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Plowed Field ({farm.PlowedFields[i].CurrectCount} rows of plants)");
                }
                Console.WriteLine();
                // How can I output the type of plant chosen here?
                Console.WriteLine($"Plant {flower.Type.ToLower()} where?");

                Console.Write("> ");
                int PlowedFieldChoice = Int32.Parse(Console.ReadLine());

                if (farm.PlowedFields[PlowedFieldChoice - 1].CurrectCount < farm.PlowedFields[PlowedFieldChoice - 1].Capacity)
                {
                    farm.PlowedFields[PlowedFieldChoice - 1].AddResource(flower);
                    Console.Clear();
                }
                else
                {
                    ChooseFlowerField.CapacityCheck(farm, flower);
                }
            }
            else if (fieldChoice == 2)
            {
                for (int i = 0; i < farm.NaturalFields.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Natural Field ({farm.NaturalFields[i].CurrectCount} rows of plants)");
                }
                Console.WriteLine();
                // How can I output the type of plant chosen here?
                Console.WriteLine($"Plant {flower.Type.ToLower()} where?");

                Console.Write("> ");
                int NaturalFieldChoice = Int32.Parse(Console.ReadLine());

                if (farm.NaturalFields[NaturalFieldChoice - 1].CurrectCount < farm.NaturalFields[NaturalFieldChoice - 1].Capacity)
                {
                    farm.NaturalFields[NaturalFieldChoice - 1].AddResource(flower);
                    Console.Clear();
                }
                else
                {
                    ChooseFlowerField.CapacityCheck(farm, flower);
                }
            }
            else if(fieldChoice == 3)
            {
                Console.Clear();

            }




        }

        public static void CapacityCheck(Farm farm, IFlower flower)
        {
            Console.Clear();
            Console.WriteLine("**** That facility is not large enough ****");
            Console.WriteLine("****     Please choose another one     ****");
            Console.WriteLine();
            ChooseFlowerField.CollectInput(farm, flower);
        }
    }
}
