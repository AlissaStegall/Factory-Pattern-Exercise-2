using System;
namespace FactoryPatternExercise2
{
	public static class DataAccessFactory
	{
            public static IDataAccess GetDataAccessType(string databaseType)
			{
				switch (databaseType.ToLower())
				{
					case "list":
						return new ListDataAccess();
						break;

					case "sql":
						return new SQLDataAccess();
						break;

					case "mongo":
						return new MongoDataAccess();

					default:
						return new ListDataAccess();
						break;
				}
			}

        
	}
}

