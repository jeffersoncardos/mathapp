using System;

namespace MathApp.App.Utils
{
  public class ConsoleUtils
  {
    public static string ReadLine(string message)
    {
      Console.Write(message);
      var command = Console.ReadLine()?.Trim();
      return command;
    }

    public static double ReadDouble(string message)
    {
      bool doubleConverted;
      double output;

      do
      {
        var typedValue = ReadLine(message);

        doubleConverted = double.TryParse(typedValue, out output);

        if (!doubleConverted) Console.WriteLine("Type a valid number.");
      } while (!doubleConverted);

      return output;
    }

    public static void WriteHeader(string message)
    {
      Console.WriteLine($"\n### {message} ###\n");
    }
  }
}
