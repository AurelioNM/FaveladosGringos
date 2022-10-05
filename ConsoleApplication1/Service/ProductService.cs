using ConsoleApplication1.Model;
using ConsoleApplication1.Product;

namespace ConsoleApplication1.Service;

public class ProductService
{

    public Order CreateOrder(string paymentMethod, long clientCpf, int price, Freezer freezerProduct)
    {
        var rnd = new Random();
        var id = rnd.Next(1000);
        
        var newOrder =new Order(id ,paymentMethod, clientCpf, price, freezerProduct);

        return newOrder;
    }
    

}