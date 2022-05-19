using MathApp.App.Interfaces.Strategies;
using System.Collections.Generic;
using System.Linq;

namespace MathApp.App.Services
{

  public class SortService
  {
    public List<TList> Sort<TList>(List<TList> list, ISortStrategy<TList> strategy)
    {
      return list.OrderBy(list => strategy.Selector(list)).ToList();
    }
  }
}
