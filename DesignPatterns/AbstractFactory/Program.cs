//Abstract Factory is a creational design pattern, which solves the problem of creating
//entire product families without specifying their concrete classes.

//Abstract Factory defines an interface for creating all distinct products
//but leaves the actual product creation to concrete factory classes.
//Each factory type corresponds to a certain product variety.
using AbstractFactory;

try
{
    Client absFactoryClient = new Client();
    var factoryName = Console.ReadLine();


    if (factoryName == null)
        Console.WriteLine("Factory name can't be empty");
    else
    {
        absFactoryClient.GetProductsFromFactory(factoryName);
        absFactoryClient.ShowProductDetails();
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}



