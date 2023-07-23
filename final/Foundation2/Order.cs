public class Order
{
    private Customer _oCustomer;
    private List<Product> _oProducts = new List<Product>();

    public Order()
    {

    }
    public Order(Customer customer, List<Product> oProds)
    {
        _oCustomer = customer;
        _oProducts = oProds;
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
    public double OrderCost()
    {
        double total = 0;
        Address auxAddress = new Address();
        auxAddress = _oCustomer.GetAddress();
        foreach (Product product in _oProducts)
        {
            total = total + product.GetProdPrice() * product.GetProdQtty();
        }
        if (auxAddress.GetStatus(auxAddress.GetCountry()))
        {
            total = total + 5;
            Console.WriteLine("\tShipping: U$ 5");
        } else {
            total = total + 35;
            Console.WriteLine("\tShipping: U$35");
        }
        return total;
    }
    public void PackingLabel() // list the name and product id of each product in the order.    
    {
        foreach(Product product in _oProducts){
            Console.WriteLine($"{product.GetProdId()}\t {product.GetProdQtty()} \t {product.GetProdName()} ");
        }
    }
    
    public void ShippingLabel() // list the name and address of the customer
    {
        Console.WriteLine($"{_oCustomer.GetName()} \n{_oCustomer.GetStringAddress()}");
    }
}