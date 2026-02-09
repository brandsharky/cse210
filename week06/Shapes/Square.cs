using System;

public class Square : Shape
{
  // Attributes
  private double _side;



  // Constructor
  public Square(string color, double side) : base(color)
  {
    this._side = side;
  }



  // Methods
  public override double GetArea()
  {
    return Math.Pow(_side, 2);
  }
}