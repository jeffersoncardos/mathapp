using MathApp.App.Domain;
using MathApp.App.Utils;

namespace MathApp.App
{
  public class AddSquareCommand : Command<Shape>
  {
    public override Shape Execute(string command)
    {
      ConsoleUtils.WriteHeader("ADDING SQUARE");

      var squareSize = ConsoleUtils.ReadDouble("Type the square side size: ");

      return new Square(squareSize);
    }
  }
}
