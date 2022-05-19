using MathApp.App.Domain;
using MathApp.App.Utils;

namespace MathApp.App
{
  public class AddCircleCommand : Command<Shape>
  {
    public override Shape Execute(string command)
    {
      ConsoleUtils.WriteHeader("ADDING CIRCLE");

      var radius = ConsoleUtils.ReadDouble("Type de radius of the circle: ");

      return new Circle(radius);
    }
  }
}
