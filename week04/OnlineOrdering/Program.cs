using System;
using System.Collections.Generic;

// Product class
public class Product
{
    private string name;
    private int id;
    private double price;
    private int quantity;

    public Product(string name, int id, double price, int quantity)
    {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }

    public double GetTotalCost()
    {
        return price * quantity;
    }

    public string GetName()
    {
        return name;
    }

    public int GetId()
    {
        return id;
    }
}

// Address class
public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return country == "USA";
    }

    public string GetFullAddress()
    {
        return $"{street}\n{city}, {state}\n{country}";
    }
}

// Customer class
public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    public string GetName()
    {
        return name;
    }

    public Address GetAddress()
    {
        return address;
    }
}

// Order class
public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }

        // Adding shipping cost
        double shippingCost = customer.IsInUSA() ? 5.0 : 35.0;
        totalCost += shippingCost;

        return totalCost;
    }

    public string GetPackagingLabel()
    {
        string label = "Product Package:\n";
        foreach (var product in products)
        {
            label += $"{product.GetName()} (ID: {product.GetId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = $"Shipped to:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}\n";
        return label;
    }
}

public class Program
{
    public static void Main()
    {
        // Creating products
        Product product1 = new Product("Product A", 101, 10.0, 2);
        Product product2 = new Product("Product B", 102, 20.0, 1);
        Product product3 = new Product("Product C", 103, 5.0, 5);

        // Creating addresses
        Address address1 = new Address("Street 1", "City X", "State Y", "USA");
        Address address2 = new Address("Street 2", "City Z", "State W", "Brazil");

        // Creating customers
        Customer customer1 = new Customer("John Silva", address1);
        Customer customer2 = new Customer("Maria Oliveira", address2);

        // Creating orders
        Order order1 = new Order(new List<Product> { product1, product2 }, customer1);
        Order order2 = new Order(new List<Product> { product2, product3 }, customer2);

        // Displaying results
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackagingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackagingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}\n");
    }
}
