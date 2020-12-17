using StrategyPattern.Contexts;

namespace StrategyPattern.Strategies.Abstractions
{
    /// <summary>
    /// El rol que juega una clase base es la de compartir 
    /// comportamiento común para todas las estratategias
    /// </summary>
    public abstract class Strategy : IStrategy
    {
        public void CommonBehavior1(string parameter1 = default)
        {
            
        }

        public abstract void DoSomething(Context1 context);
    }
}