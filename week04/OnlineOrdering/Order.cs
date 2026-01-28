using System;
using System.Collections.Generic;

class Order
{
  // Attributes
  private List<Product> _products = new List<Product>();
  private Customer _customer;



  // Constructors
  public Order(Customer customer)
  {
    this._customer = customer;
  }



  // Methods
  public void AddProduct(Product product)
  {
    _products.Add(product);
  }


  public double GetTotalCost()
  {
    double total = 0;

    foreach (Product product in _products)
    {
      total += product.GetTotalCost();
    }

    double shippingCost = 0;

    if (_customer.LivesInUSA())
    {
      shippingCost = 5;
    }
    else
    {
      shippingCost = 35;
    }
    total += shippingCost;

    return total;
  }


  public string GetPackingLabel()
  {
    string label = "Packing Label:\n";

    foreach (Product product in _products)
    {
      label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
    }

    return label;
  }


  public string GetShippingLabel()
  {
    string label = $"Shipping Label:\n";
    label += $"{_customer.GetName()}\n";
    label += $"{_customer.GetAddress().GetFullAddress()}\n";

    return label;
  }
}