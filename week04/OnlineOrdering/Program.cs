using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the first customer's address and customer
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "New York",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        // Create products for the first order
        Product product1 = new Product("Laptop", "P001", 800.00, 1);
        Product product2 = new Product("Mouse", "P002", 25.00, 2);

        // Create the first order
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);


        // Create the second customer's address and customer
        Address address2 = new Address(
            "15 Victoria Island Road",
            "Lagos",
            "Lagos State",
            "Nigeria"
        );

        Customer customer2 = new Customer("David Johnson", address2);

        // Create products for the second order
        Product product3 = new Product("Keyboard", "P003", 50.00, 2);
        Product product4 = new Product("Headphones", "P004", 75.00, 1);

        // Create the second order
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);


        // Display the first order
        Console.WriteLine("================================");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("================================");

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine(
            $"Total Order Cost: ${order1.GetTotalCost():F2}"
        );


        // Display the second order
        Console.WriteLine("\n================================");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("================================");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine(
            $"Total Order Cost: ${order2.GetTotalCost():F2}"
        );
    }
}