using System;

public class WritingAssignment : Assignment
{
  // Attributes
  private string _title;



  // Constructors
  public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
  {
    this._title = title;
  }



  // Methods
  public string GetWritingInformation()
  {
    return $"{_title} by {GetStudentName()}";
  }
}