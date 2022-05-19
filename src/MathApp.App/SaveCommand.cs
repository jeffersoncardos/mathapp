using MathApp.App.Services;
using MathApp.App.Utils;

namespace MathApp.App
{
  public class SaveCommand : Command
  {
    private ShapeService _shapeService;

    public SaveCommand()
    {
      _shapeService = new ShapeService();
    }

    public override void Execute(string command)
    {
      _shapeService.Save();
      ConsoleUtils.WriteHeader("All entries was saved to the disk.");
    }
  }
}
