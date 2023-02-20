namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
             string userInput;
            bool correctInput;
            do
            {
             correctInput= true;

             Console.WriteLine("What type of database would you like to access?");

             Console.WriteLine("TYPE: SQL, Mongo, List");

             userInput= Console.ReadLine();

                if(userInput != "sql" && userInput != "mongo" && userInput != "list")
                {
                    correctInput= false;
                    Console.WriteLine("Error: Incorrect Input");
                }
                

            }while(correctInput==false);
            Console.Clear();

             IDataAccess database =  DataAccessFactory.GetDataAccessType(userInput);
            



            var products = database.LoadData();
            database.SaveData();

            foreach (var product in products)
            {
                Console.WriteLine($"Name: { product.Name} Price: {product.Price}");
            }
        }
    }
}
