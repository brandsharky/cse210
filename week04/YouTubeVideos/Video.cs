using System;
using System.Collections.Generic;

class Video
{
  // Attributes
  public string _title;
  public string _author;
  public int _length;
  public List<Comment> _comments = new List<Comment>();



  // Constructors
  public Video(string title, string author, int length)
  {
    this._title = title;
    this._author = author;
    this._length = length;
  }



  // Methods
  public void AddComment(Comment comment)
  {
    _comments.Add(comment);
  }


  public int GetNumberOfComments()
  {
    return _comments.Count;
  }
}