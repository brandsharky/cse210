using System;

class Address
{
  // Attributes
  private string _street;
  private string _city;
  private string _state;
  private string _country;



  // Constructors
  public Address(string street, string city, string state, string country)
  {
    this._street = street;
    this._city = city;
    this._state = state;
    this._country = country;
  }



  // Methods
  public bool IsInUSA()
  {
    if (_country.ToLower() == "usa" || _country.ToLower() == "united states of america" || _country.ToLower() == "united states")
    {
      return true;
    }
    return false;
  }


  public string GetFullAddress()
  {
    string formattedAddress = $"{_street}\n{_city}, {_state}\n{_country}";

    return formattedAddress;
  }
}