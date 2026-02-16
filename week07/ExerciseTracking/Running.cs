using System;

public class Running : Activity
{
  // Attributes
  private double _distance;



  // Constructors
  public Running(DateTime date, int minutes, double distance) : base(date, minutes)
  {
    this._distance = distance;
  }



  // Method
  public override double GetDistance()
  {
    return _distance;
  }


  public override double GetSpeed()
  {
    return (_distance / GetMinutes()) * 60;
  }


  public override double GetPace()
  {
    return GetMinutes() / _distance;
  }
}