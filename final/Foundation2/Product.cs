public class Product
{
    private string _prodId;
    private string _prodName;
    private double _prodPrice;
    private int _prodQtty;

    public Product(string prodId, string prodName, double price, int qtty)
    {
        _prodId = prodId;
        _prodName = prodName;
        _prodPrice = price;
        _prodQtty = qtty;
    }   
    
    public void SetProdId(string prodId)
    {
        _prodId = prodId;
    }
    public void SetProdName(string name)
    {
        _prodName = name;
    }
    public void SetProdPrice(double price)
    {
        _prodPrice = price;
    }
    public void SetProdQtty(int qtty)
    {
        _prodQtty = qtty;
    }
    
    public string GetProdId()
    {
        return _prodId;
    }
    public string GetProdName()
    {
        return _prodName;
    }
    public double GetProdPrice()
    {
        return _prodPrice;
    }
    public int GetProdQtty()
    {
        return _prodQtty;
    }
    
}