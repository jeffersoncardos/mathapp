using MathApp.App.Domain;
using MathApp.App.Utils;

namespace MathApp.App
{
  public class AddIsocelesCommand : Command<Shape>
  {
    public override Shape Execute(string command)
    {
      ConsoleUtils.WriteHeader("ADDING ISOCELES TRIANGLE");

      var doubledSide = ConsoleUtils.ReadDouble("Type the triangle doubled side: ");
      var differentSide = ConsoleUtils.ReadDouble("Type the triangle different side: ");

      return new Isoceles(doubledSide, differentSide);
    }
  }
}
