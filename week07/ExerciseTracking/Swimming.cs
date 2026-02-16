using System;

public class Swimming : Activity
{
  // Attributes
  private int _laps;



  // Constructors
  public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
  {
    this._laps = laps;
  }



  // Method
  public override double GetDistance()
  {
    return (_laps * 50) / (1000 * 0.62);
  }


  public override double GetSpeed()
  {
    return (GetDistance() / GetMinutes()) * 60;
  }


  public override double GetPace()
  {
    return GetMinutes() / GetDistance();
  }
}