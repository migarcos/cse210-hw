public class Product
{
    private string _prodId;
    private string _prodName;
    private float _prodPrice;
    private int _prodQtty;

    private Product(string prodId, string prodName, float price, int qtty)
    {
        _prodId = prodId;
        _prodName = prodName;
        _prodPrice = price;
        _prodPrice = qtty;
    }   
    
    public void SetProdId(string prodId)
    {
        _prodId = prodId;
    }
    public void SetProdName(string name)
    {
        _prodName = name;
    }
    public void SetProdPrice(float price)
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
    public float GetProdPrice()
    {
        return _prodPrice;
    }
    public int GetProdQtty()
    {
        return _prodQtty;
    }
    
}