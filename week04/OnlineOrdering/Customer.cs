using System;

class Customer
{
  // Attributes
  private string _name;
  private Address _address;



  // Constructors
  public Customer(string name, Address address)
  {
    this._name = name;
    this._address = address;
  }



  // Methods
  public bool LivesInUSA()
  {
    return _address.IsInUSA();
  }


  public string GetName()
  {
    return _name;
  }

  public Address GetAddress()
  {
    return _address;
  }
}