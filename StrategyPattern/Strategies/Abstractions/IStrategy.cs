using StrategyPattern.Contexts;

namespace StrategyPattern.Strategies.Abstractions
{
    /// <summary>
    /// La intefaz define el contrato por la cual el <see cref="Context1"/> 
    /// invocará la estrategia.
    /// </summary>
    public interface IStrategy
    {
        void DoSomething(Context1 context);
    }
}