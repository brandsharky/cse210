using System;

public abstract class Activity
{
  // Attributes
  private DateTime _date;
  private int _minutes;



  // Constructors
  public Activity(DateTime date, int minutes)
  {
    this._date = date;
    this._minutes = minutes;
  }



  // Method
  public DateTime GetDate()
  {
    return _date;
  }


  public int GetMinutes()
  {
    return _minutes;
  }


  public abstract double GetDistance(); // miles
  public abstract double GetSpeed(); // mph
  public abstract double GetPace(); // minutes per mile


  public virtual string GetSummary()
  {
    return $"{_date:dd MM yyyy} {this.GetType().Name} ({_minutes} min) - \nDistance: {GetDistance():0.00} miles\nSpeed: {GetSpeed():0.00} mph\nPace: {GetPace():0.00} min per mile";
  }
}