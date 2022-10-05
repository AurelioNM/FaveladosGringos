using ConsoleApplication1.Model;
using ConsoleApplication1.Product;
using ConsoleApplication1.Service;
using ConsoleApplication1.Storage;

public static class Program
{
    public static void Main(string[] args)
    {
        var fakeDatabase = new Storage();
        
        var freezerOne = new Freezer(1, 250, "Diogo-freezers");
        var freezerTwo = new Freezer(2, 300, "Ariane-freezers");

        var productService = new ProductService();

        Order firstOrder = productService.CreateOrder("card", 9043721, 450, freezerOne);
        
        var ordersList = fakeDatabase.OrdersList;

        ordersList.Add(firstOrder);

        Console.WriteLine(ordersList[0]);
    }
}