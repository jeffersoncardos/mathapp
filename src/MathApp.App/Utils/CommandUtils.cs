using System;
using System.Linq;

namespace MathApp.App.Utils
{
  public class CommandUtils
  {
    public static void ExecuteCommand(string command)
    {
      ExecuteCommand(command, "Invalid command");
    }

    public static void ExecuteCommand(string command, string errorMessage)
    {
      var commandType = typeof(Command).Assembly.GetTypes()
                .FirstOrDefault(type => type.IsSubclassOf(typeof(Command))
                  && type.Name.ToLower().Equals(command.Trim().ToLower() + "command"));

      if (commandType == null) Console.WriteLine(errorMessage);
      else
      {
        var commandInstance = (Command)Activator.CreateInstance(commandType);
        commandInstance.Execute(command);
      }
    }



    public static TReturns ExecuteCommand<TReturns>(string command, string errorMessage)
    {
      var commandType = typeof(Command<TReturns>).Assembly.GetTypes()
                .FirstOrDefault(type => type.IsSubclassOf(typeof(Command<TReturns>))
                  && type.Name.ToLower().Equals(command.Trim().ToLower() + "command"));

      if (commandType == null)
      {
        Console.WriteLine(errorMessage);
        return default(TReturns);
      }

      var commandInstance = (Command<TReturns>)Activator.CreateInstance(commandType);
      var response = commandInstance.Execute(command);
      return response;
    }
  }
}
