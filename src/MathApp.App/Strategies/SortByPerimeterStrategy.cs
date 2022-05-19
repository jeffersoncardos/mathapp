using MathApp.App.Domain;
using MathApp.App.Interfaces.Strategies;

namespace MathApp.App.Strategies
{
  public class SortByPerimeterStrategy : ISortStrategy<Shape>
  {
    public object Selector(Shape sortItem)
    {
      return sortItem.GetPerimeter();
    }
  }
}
