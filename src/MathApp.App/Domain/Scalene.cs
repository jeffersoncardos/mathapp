using System;

namespace MathApp.App.Domain
{
  public class Scalene : Triangle
  {
    public Scalene(double sideOne, double sideTwo, double sideThree)
    {
      A = sideOne;
      B = sideTwo;
      C = sideThree;
    }

    public override double GetArea()
    {
      var p = (A + B + C) / 2;
      return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 2);
    }

    public override double GetHeight()
    {
      return Math.Round(2 * GetArea() / A, 2);
    }
  }
}
