using System;

namespace MathApp.App.Domain
{
  public abstract class Quadrilateral : Shape
  {
    public double Width { get; set; }
    public double Length { get; set; }

    public override double GetArea()
    {
      return Math.Round(Width * Length, 2);
    }

    public override double GetPerimeter()
    {
      return Math.Round((Width + Length) * 2, 2);
    }
  }
}
