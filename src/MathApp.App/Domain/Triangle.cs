namespace MathApp.App.Domain
{
  public abstract class Triangle : Shape
  {
    /// <summary>
    /// base of the triangle
    /// </summary>
    public double A { get; set; }
    /// <summary>
    /// side one of the triangle
    /// </summary>
    public double B { get; set; }
    /// <summary>
    /// side two of the triangle
    /// </summary>
    public double C { get; set; }

    public abstract double GetHeight();

    public override double GetPerimeter()
    {
      return A + B + C;
    }
  }
}
