using ConsoleApplication1.Product;

namespace ConsoleApplication1.Model;

public class Order
{
    public int Id;
    public string PaymentMethod;
    public long ClientCPF;
    public int Price;
    public Freezer FreezerProduct;

    public Order(
        int id, 
        string paymentMethod, 
        long clientCpf, 
        int price, 
        Freezer freezerProduct
        )
    {
        Id = id;
        PaymentMethod = paymentMethod;
        ClientCPF = clientCpf;
        Price = price;
        FreezerProduct = freezerProduct;
    }
    
    public Order() {}

}