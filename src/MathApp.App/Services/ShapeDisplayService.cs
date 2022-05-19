using ConsoleTables;
using MathApp.App.Domain;
using System;
using System.Collections.Generic;

namespace MathApp.App.Services
{
  public class ShapeDisplayService
  {
    internal void DisplayTable(IReadOnlyList<Shape> shapes)
    {
      var table = new ConsoleTable("Type", "Area", "Perimeter");

      foreach (var shape in shapes)
      {
        table.AddRow(shape.Name, shape.GetArea(), shape.GetPerimeter());
      }

      DisplayTable(table);
    }

    private static void DisplayTable(ConsoleTable table)
    {
      table.Write();
      Console.WriteLine();
    }

    internal void DisplayTable(Dictionary<string, int> groups)
    {
      var table = new ConsoleTable("Shape Type", "Count");

      foreach (var item in groups)
        table.AddRow(item.Key, item.Value);

      DisplayTable(table);
    }
  }
}
