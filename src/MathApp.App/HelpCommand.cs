using MathApp.App.Utils;
using System;
using System.Text;

namespace MathApp.App
{
  public class HelpCommand : Command
  {
    public override void Execute(string command)
    {
      ConsoleUtils.WriteHeader("Showing help page");

      var builder = new StringBuilder();

      builder.AppendLine(new string('-', 80));
      builder.AppendLine();
      builder.AppendLine("  add - Add new shape.\n");
      builder.AppendLine("      [shape name] - after [add], you'll use the shape name to define which shape would you like to add.\n");
      builder.AppendLine("  list - List the shapes that are in memory.\n");
      builder.AppendLine("  save - Write the shapes that are in memory on disk.\n");
      builder.AppendLine("  sortBy - Sorts the list by [area] or [perimeter].\n");
      builder.AppendLine("      [sort type] - after [sortby], use the avalable sort types that will be displayed on the screen.\n");
      builder.AppendLine("  group - Count the shapes by shape type.\n");
      builder.AppendLine("  help - show this help page.\n");
      builder.AppendLine("  exit - finish the execution of the app.");
      builder.AppendLine("\n\n");

      Console.WriteLine(builder.ToString());
    }
  }
}
