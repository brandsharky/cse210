using System;

public class Circle : Shape
{
  // Attributes
  private double _radius;



  // Constructor
  public Circle(string color, double radius) : base(color)
  {
    this._radius = radius;
  }



  // Methods
  public override double GetArea()
  {
    return Math.PI * Math.Pow(_radius, 2);
  }
}