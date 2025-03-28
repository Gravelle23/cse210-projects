using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Maple St.", "Los Angeles", "CA", "USA");
        Address address2 = new Address("456 Oak St.", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Jane Doe", address1);
        Customer customer2 = new Customer("Bob Smith", address2);

        Product product1 = new Product("Laptop", 101, 1200.00, 1);
        Product product2 = new Product("Mouse", 102, 25.50, 2);
        Product product3 = new Product("Keyboard", 103, 50.00, 1);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}



    
