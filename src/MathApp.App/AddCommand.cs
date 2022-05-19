using MathApp.App.Domain;
using MathApp.App.Services;
using MathApp.App.Utils;
using System;
using System.Linq;

namespace MathApp.App
{
  public class AddCommand : Command
  {
    private readonly ShapeService _shapeService;

    public AddCommand()
    {
      _shapeService = new ShapeService();
    }

    public override void Execute(string command)
    {
      Console.WriteLine("\nADDING NEW SHAPE\n");

      var shapes = _shapeService.GetAvailableShapes();
      var shapesNames = string.Join(", ", shapes);
      var shapeName = string.Empty;

      do
      {
        Console.WriteLine($"Type the name of the shape");
        Console.WriteLine($"\n( {shapesNames} )\n");
        shapeName = ConsoleUtils.ReadLine($">>> ");

        var shape = CommandUtils.ExecuteCommand<Shape>($"add{shapeName.ToLower()}", $"\nThe shape [{shapeName}] is invalid.\n");

        if (shape != null)
        {
          _shapeService.Add(shape);

          ConsoleUtils.WriteHeader("Shape added successfuly!");
        }
      } while (!shapes.Any(shape => shape.Equals(shapeName, StringComparison.InvariantCultureIgnoreCase)));
    }
  }
}
