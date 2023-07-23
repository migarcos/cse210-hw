using System;

class Program
{
    static void Main(string[] args)
    {
        // Order ONE
        Address tempAddress = new Address("Calle 5D 30-45","Popayán","COL");
        Customer newC01 = new Customer("Miguel Arcos", tempAddress);
        
        Product auxProd = new Product("129024","Acetic Silicone 280ml",4,5);
        List<Product> prods1 = new List<Product>();
        prods1.Add(auxProd);

        auxProd = new Product("128395","Acryilic Sealant 300ml",3.5,12);
        prods1.Add(auxProd);
        auxProd = new Product("137745","Soudaflex 620 PU",8,3);
        prods1.Add(auxProd);

        Order order1 = new Order(newC01, prods1);

        order1.ShippingLabel();
        order1.PackingLabel();
        Console.WriteLine($"\tOrder cost: {order1.OrderCost()}");
        

        Console.WriteLine("\n - - - - - - - - - - - - - - \n");
        // Second Order
        tempAddress  = new Address("7716 NE Loop 820, North Richland Hills", "TX 76180", "USA");
        Customer newC02 = new Customer("William Watson", tempAddress);
        List<Product> prods2 = new List<Product>();
        auxProd = new Product("129025","White Acetic Silicone 280ml",4.75,3);
        prods2.Add(auxProd);

        auxProd = new Product("119029","CA 1400 280ml",13.5,1);
        prods2.Add(auxProd);
        auxProd = new Product("121144","Soudafoam 1K 500+250ml",10,4);
        prods2.Add(auxProd);

        Order order2 = new Order(newC02, prods2);

        order2.ShippingLabel();
        order2.PackingLabel();
        Console.WriteLine($"\tOrder cost: {order2.OrderCost()}");
        


        // Order order01 = new Order();

        // Console.WriteLine(newC01.GetName());
        // Console.WriteLine(newC01.GetStringAddress());
        // string name, address;

        // name = newC01.GetName();
        // address = newC01.GetStringAddress();
        // Console.WriteLine($"{name} {address}");
        
        // Console.WriteLine(newC02.GetName());
        // Console.WriteLine(newC02.GetStringAddress());
        // Console.WriteLine($"{newC02.GetName()} {newC02.GetStringAddress()}");


    }
}