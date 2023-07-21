public class Order
{
    private Customer _oCustomer;
    private List<Product> _oProducts = new List<Product>();

    public Order()
    {

    }
    public void SetCustomer(string name, Address address)
    {
        _oCustomer = new Customer(name, address);
    }
    public Customer GetCustomer()
    {
        return _oCustomer;
    }
    public void SetProducts(List<Product> Products)
    {
        _oProducts = Products;
    }
    public List<Product> GetProducts()
    {
        return _oProducts;
    }
    public float OrderCost()
    {
        float total = 0;
        foreach (Product product in _oProducts)
        {
            total = total + product.GetProdPrice() * product.GetProdQtty();
        }
        // if (_oCustomer.GetStatus())
        // {
        //     total = total + 5;
        // } else {
        //     total = total + 35;
        // }
        return total;
    }
    public void PackingLabel() // list the name and product id of each product in the order.    
    {
        foreach(Product product in _oProducts){
            Console.WriteLine($"{product.GetProdId} \t {product.GetProdName()}");
        }
    }
    
    public void ShippingLabel() // list the name and address of the customer
    {
        Console.WriteLine($"{_oCustomer.GetName()} \n{_oCustomer.GetAddress()}");
    }
}