using System;

namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess
	{
		public ListDataAccess()
		{
		}
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name = "Oreos", Price = 5},
            new Product(){Name = "Reeses", Price = 3},
            new Product(){Name = "Milk", Price = 2}
        };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading this data from ListDataAcces");
            Console.WriteLine("");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from the List data base");
            Console.WriteLine("");
        }
    }
}

