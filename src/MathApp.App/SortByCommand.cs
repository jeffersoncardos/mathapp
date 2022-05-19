using MathApp.App.Domain;
using MathApp.App.Interfaces.Strategies;
using MathApp.App.Services;
using MathApp.App.Strategies;
using MathApp.App.Utils;
using System;
using System.Linq;

namespace MathApp.App
{
  public class SortByCommand : Command
  {
    private ShapeService _shapeService;
    private SortService _sortService;
    private ShapeDisplayService _shapeDisplayService;

    public SortByCommand()
    {
      _shapeService = new ShapeService();
      _sortService = new SortService();
      _shapeDisplayService = new ShapeDisplayService();
    }

    public override void Execute(string command)
    {
      Console.WriteLine("\nInform the sort order ( area | perimeter )");

      var sortOrder = ConsoleUtils.ReadLine(">>>");

      var shapes = _shapeService.GetAll();
      var sortStrategy = sortOrder.ToLower() switch
      {
        "area" => new SortByAreaStrategy(),
        "perimeter" => new SortByPerimeterStrategy(),
        _ => default(ISortStrategy<Shape>)
      };

      if (sortStrategy == null)
        ConsoleUtils.WriteHeader("The sort order is invalid or unavailable");
      else
      {
        ConsoleUtils.WriteHeader($"SORTING ITEM BY {sortOrder?.ToUpper()}");
        shapes = _sortService.Sort(shapes.ToList(), sortStrategy);
      }

      _shapeDisplayService.DisplayTable(shapes);
    }
  }
}
