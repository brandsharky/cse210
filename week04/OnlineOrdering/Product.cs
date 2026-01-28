using System;

class Product
{
  // Attributes
  private string _name;
  private string _productId;
  private double _price;
  private int _quantity;



  // Constructors
  public Product(string name, string productId, double price, int quantity)
  {
    this._name = name;
    this._productId = productId;
    this._price = price;
    this._quantity = quantity;
  }



  // Methods
  public double GetTotalCost()
  {
    return _price * _quantity;
  }


  public string GetName()
  {
    return _name;
  }

  public string GetProductId()
  {
    return _productId;
  }

  public double GetPrice()
  {
    return _price;
  }

  public int GetQuantity()
  {
    return _quantity;
  }
}