using MathApp.App.Domain;
using MathApp.App.Utils;

namespace MathApp.App
{
  public class AddRectangleCommand : Command<Shape>
  {
    public override Shape Execute(string command)
    {
      ConsoleUtils.WriteHeader("ADDING RECTANGLE");

      var width = ConsoleUtils.ReadDouble("Type the rectangle width: ");
      var length = ConsoleUtils.ReadDouble("Type the rectangle length: ");

      return new Rectangle(width, length);
    }
  }
}
