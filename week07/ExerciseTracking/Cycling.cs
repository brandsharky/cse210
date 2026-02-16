using System;

public class Cycling : Activity
{
  // Attributes
  private double _speed;



  // Constructors
  public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
  {
    this._speed = speed;
  }



  // Method
  public override double GetDistance()
  {
    return (_speed / GetMinutes()) * 60;
  }


  public override double GetSpeed()
  {
    return _speed;
  }


  public override double GetPace()
  {
    return 60 / _speed;
  }
}