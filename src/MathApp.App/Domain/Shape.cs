namespace MathApp.App.Domain
{
  public abstract class Shape
  {
    public string Name => GetType().Name;

    public abstract double GetArea();
    public abstract double GetPerimeter();
  }
}
