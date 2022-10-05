namespace ConsoleApplication1.Product;

// Forma de biscoitos
public class Freezer
{

    public int Id;
    public int Price;
    public string Brand;

    public Freezer(int id, int price, string brand)
    {
        Console.WriteLine("Conectando com banco de dados");
        Id = id;
        Price = price;
        Brand = brand;
    }

}