namespace MathApp.App.Interfaces.Strategies
{
  public interface ISortStrategy<TList>
  {
    object Selector(TList sortItem);
  }
}
