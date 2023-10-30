// See https://aka.ms/new-console-template for more information
using SqlPrject;
class Program 
{
    //private string connectoinString = "Data Source=SRV2\\PUPILS;Initial Catalog = WebElectricStore1; Integrated Security = True";
    static void Main(string[] args)
    {
        DataAccess da = new DataAccess();
        Console.WriteLine("are you want to insert new category, please enter y/n");
        string resC = Console.ReadLine();
        while(resC == "y")
        {
            da.InsertDataCategory("Data Source=SRV2\\PUPILS;Initial Catalog = WebElectricStore1; Integrated Security = True");
            da.readDataCategory("Data Source=SRV2\\PUPILS;Initial Catalog = WebElectricStore1; Integrated Security = True");
            Console.WriteLine("are you want to insert new category, please enter y/n");
            resC = Console.ReadLine();
        }

        Console.WriteLine("are you want to insert new product, please enter y/n");
        string resP = Console.ReadLine();
        while (resP == "y")
        {
            da.InsertDate("Data Source=SRV2\\PUPILS;Initial Catalog = WebElectricStore1; Integrated Security = True");
            da.readData("Data Source=SRV2\\PUPILS;Initial Catalog = WebElectricStore1; Integrated Security = True");
            Console.WriteLine("are you want to insert new product, please enter y/n");
            resP = Console.ReadLine();
        }
           
    }
        
}

