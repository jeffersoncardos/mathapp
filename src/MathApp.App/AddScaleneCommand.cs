using MathApp.App.Domain;
using MathApp.App.Utils;

namespace MathApp.App
{
  public class AddScaleneCommand : Command<Shape>
  {
    public override Shape Execute(string command)
    {
      ConsoleUtils.WriteHeader("ADDING SCALENE TRIANGLE");

      var sideOne = ConsoleUtils.ReadDouble("Type the first side of triangle: ");
      var sideTwo = ConsoleUtils.ReadDouble("Type the second side of triangle: ");
      var sideThree = ConsoleUtils.ReadDouble("Type the third side of triangle: ");

      return new Scalene(sideOne, sideTwo, sideThree);
    }
  }
}
