using System;

namespace MathApp.App.Domain
{
  public class Square : Quadrilateral
  {
    public Square(double size)
    {
      Width = size;
      Length = size;
    }
  }
}
