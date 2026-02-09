using System;

public class Rectangle : Shape
{
  // Attributes
  private double _length;
  private double _width;



  // Constructor
  public Rectangle(string color, double length, double width) : base(color)
  {
    this._length = length;
    this._width = width;
  }



  // Methods
  public override double GetArea()
  {
    return _length * _width;
  }
}