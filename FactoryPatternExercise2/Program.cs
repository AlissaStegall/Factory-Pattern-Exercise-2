namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool correctInput;
            do
            {
                correctInput = true;
                Console.WriteLine("Please enter what data base you would like to use: \nlist \nsql \nmongo");
                Console.WriteLine("");
                input = Console.ReadLine();
                input.ToLower();

                if (input != "sql" && input != "mongo" && input != "list")
                {
                    correctInput = false;
                    Console.WriteLine("Incorrect input follow the prompt below-");
                }

            } while (correctInput == false);

            var dataBase = DataAccessFactory.GetDataAccessType(input);

            var products = dataBase.LoadData();

            dataBase.SaveData();

                foreach(var product in products)
                {
                Console.WriteLine($"Name: {product.Name} \nPrice: {product.Price}");
                Console.WriteLine("");
                }
        }
    }
}
