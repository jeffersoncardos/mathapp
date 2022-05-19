using System;

namespace MathApp.App
{
  public class ExitCommand : Command
  {
    public override void Execute(string command)
    {
      Console.WriteLine("\n\nSee you soon. Bye!! :D\n");
    }
  }
}
