namespace MathApp.App
{
  public abstract class Command
  {
    public abstract void Execute(string command);
  }

  public abstract class Command<TReturns>
  {
    public abstract TReturns Execute(string command);
  }
}
