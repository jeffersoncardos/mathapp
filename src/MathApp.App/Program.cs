using MathApp.App.Services;
using MathApp.App.Utils;
using System;

namespace MathApp.App
{
  class Program
  {
    private static string CLOSE_PROGRAM_COMMAND = "exit";

    static void Main(string[] args)
    {
      string command;

      var _shapeService = new ShapeService();

      _shapeService.LoadFromDisk();

      do
      {
        command = ConsoleUtils.ReadLine("Type your command: ");

        CommandUtils.ExecuteCommand(command);

        Console.WriteLine(new string('-', 80));

      } while (!command.Equals(CLOSE_PROGRAM_COMMAND, StringComparison.InvariantCultureIgnoreCase));

      Console.Write("\n...");
      Console.ReadKey();
    }
  }
}
