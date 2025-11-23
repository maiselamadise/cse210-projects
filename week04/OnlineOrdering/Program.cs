using System;

class Program
{
    static void Main(string[] args)
    {
        // ===== ORDER 1 =====
        Address address1 = new Address("123 Maple St", "Provo", "UT", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop Mouse", "M123", 15.99, 2));
        order1.AddProduct(new Product("USB Keyboard", "K456", 29.99, 1));

        // ===== ORDER 2 =====
        Address address2 = new Address("77 Green Road", "London", "LDN", "UK");
        Customer customer2 = new Customer("Emma Brown", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Wireless Headphones", "H789", 55.50, 1));
        order2.AddProduct(new Product("32GB Flash Drive", "F101", 12.25, 3));

        // ===== DISPLAY RESULTS =====

        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        Console.WriteLine("===== ORDER 2 =====");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}\n");
    }
}
