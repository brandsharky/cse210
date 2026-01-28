/*
Online Ordering Program

Brandon Arroyo
1/28/2025
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("20151 Piazzale Angelo Moratti", "Milan", "Milano", "Italy");
        Customer customer1 = new Customer("Marco Materazzi", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Nike Mercurial", "1234gybh", 275.00, 1));
        order1.AddProduct(new Product("Pens", "98g7s987s98j8j", 17.99, 42));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}");



        Console.WriteLine("\n\n");



        Address address2 = new Address("1344 North Canyon Road", "Provo", "Utah", "USA");
        Customer customer2 = new Customer("C. Shane Reese", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Come Follow Me Manual", "0127932136", 29.99, 30));
        order2.AddProduct(new Product("For The Strength of Youth", "45642169884", 9.99, 40));
        order2.AddProduct(new Product("Books of Mormon", "421036940055", 15.99, 400)); // If you've seen the movie "The Best Two Years", then you know.

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}