using System;

namespace MathApp.App.Domain
{
  public class Circle : Shape
  {
    const double PI = 3.14;

    public Circle(double radius)
    {
      Radius = radius;
    }

    public double Radius { get; set; }

    public override double GetArea()
    {
      return Math.Round(PI * Radius, 2);
    }

    public override double GetPerimeter()
    {
      return Math.Round(2 * PI * Radius, 2);
    }
  }
}
