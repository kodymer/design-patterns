using StrategyPattern.Contexts;
using StrategyPattern.Strategies.Abstractions;

namespace StrategyPattern.ConcreteStrategies
{
    public class ConcreteStrategy2 : Strategy
    {
        
        private readonly string _field1;

        public ConcreteStrategy2()
        {
            _field1 = default;
        }

        public ConcreteStrategy2(string field1)
            : this()
        {
            // Guard Clause
            
            _field1 = field1;
        }

        /// <summary>
        /// Principio a tener en cuenta: SO[L]ID 
        /// </summary>
        public override void DoSomething(Context1 context)
        {

            ///
            /// Invocamos comportamiento común para todas las estrategias
            /// 
            
            CommonBehavior1();
       
        }
    }
}