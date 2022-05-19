using MathApp.App.Domain;
using MathApp.App.Utils;

namespace MathApp.App
{
  public class AddEquilateralCommand : Command<Shape>
  {
    public override Shape Execute(string command)
    {
      ConsoleUtils.WriteHeader("ADDING EQUILATERAL TRIANGLE");

      var sideSize = ConsoleUtils.ReadDouble("Type the triangle side size: ");

      return new Equilateral(sideSize);
    }
  }
}
