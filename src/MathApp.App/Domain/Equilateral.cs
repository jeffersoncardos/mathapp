using System;

namespace MathApp.App.Domain
{
  public class Equilateral : Triangle
  {
    public Equilateral(double sideSize)
    {
      A = sideSize;
      B = sideSize;
      C = sideSize;
    }

    public override double GetHeight()
    {
      return Math.Round(Math.Sqrt(Math.Pow(B, 2) - Math.Pow(A / 2, 2)), 2);
    }

    public override double GetArea()
    {
      return Math.Round(GetHeight() * A / 2, 2);
    }
  }
}
