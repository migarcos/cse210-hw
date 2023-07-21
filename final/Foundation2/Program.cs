using System;

class Program
{
    static void Main(string[] args)
    {
        Address tempAddress = new Address("Calle 5D 30-45","Popayán","COL");
        Customer newC01 = new Customer("Miguel Arcos", tempAddress);

        tempAddress  = new Address("7716 NE Loop 820, North Richland Hills", "TX 76180", "USA");
        Customer newC02 = new Customer("William Watson", tempAddress);
        
        // Order order01 = new Order();

        Console.WriteLine(newC01.GetName());
        Console.WriteLine(newC01.GetCAdrress());
        string name, address;

        name = newC01.GetName();
        address = newC01.GetCAddress();
        Console.WriteLine($"{name} {address}");
        
        Console.WriteLine(newC02.GetName());
        Console.WriteLine(newC02.GetCAdrress());
        // Console.WriteLine($"{newC02.GetName()} {newC02.GetCAddress()}");
    }
}