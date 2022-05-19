using ConsoleTables;
using MathApp.App.Services;
using MathApp.App.Utils;
using System;

namespace MathApp.App
{
  public class ListCommand : Command
  {
    private readonly ShapeService _shapeService;
    private readonly ShapeDisplayService _shapeDisplayService;

    public ListCommand()
    {
      _shapeService = new ShapeService();
      _shapeDisplayService = new ShapeDisplayService();
    }
    public override void Execute(string command)
    {
      ConsoleUtils.WriteHeader("LISTING ALL SHAPES");

      var shapes = _shapeService.GetAll();

      _shapeDisplayService.DisplayTable(shapes);
    }
  }

  public class GroupCommand : Command
  {

    private readonly ShapeService _shapeService;
    private readonly ShapeDisplayService _shapeDisplayService;

    public GroupCommand()
    {
      _shapeService = new ShapeService();
      _shapeDisplayService = new ShapeDisplayService();
    }

    public override void Execute(string command)
    {
      ConsoleUtils.WriteHeader("LISTING ALL GROUPING SHAPES");

      var groups = _shapeService.GetGroups();

      _shapeDisplayService.DisplayTable(groups);
    }
  }
}
