
using System;

class Fraction
{
  // Attributes
  private int _topNumber;
  private int _bottomNumber;

  // Getters and Setters
  public int GetTopNumber()
  {
    return _topNumber;
  }
  public void SetTopNumber(int topNumber)
  {
    this._topNumber = topNumber;
  }

  public int GetBottomNumber()
  {
    return _bottomNumber;
  }
  public void SetBottomNumber(int bottomNumber)
  {
    if (bottomNumber == 0)
    {
      Console.WriteLine("Bottom number cannot be 0.");
      return;
    }

    this._bottomNumber = bottomNumber;
  }



  // Constructors
  public Fraction()
  {
    this._topNumber = 1;
    this._bottomNumber = 1;
  }

  public Fraction(int topNumber)
  {
    this._topNumber = topNumber;
    this._bottomNumber = 1;
  }

  public Fraction(int topNumber, int bottomNumber)
  {
    this._topNumber = topNumber;
    this._bottomNumber = bottomNumber;
  }



  // Methods
  public string GetFractionString()
  {
    return $"{_topNumber}/{_bottomNumber}";
  }

  public double GetDecimalValue()
  {
    return (double)_topNumber / (double)_bottomNumber;
  }
}