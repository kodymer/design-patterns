using System.Data;
using System;
using StrategyPattern.Contexts;
using StrategyPattern.Strategies.Abstractions;

namespace StrategyPattern.ConcreteStrategies
{
    /// <summary>
    /// Cada implementación concreta de la estrategia deberá tener 
    /// una pequeña y simple responsabilidad.
    /// Cada implementación concreta de la estrategia resuelve un caso en 
    /// particular, lo que hace facil su mantenimiento. 
    /// Se pueden crear tantas estrategias concretas como sea necesario.
    /// </summary>
    public class ConcreteStrategy1 : Strategy
    {
        
        private readonly string _field1;
        
        public ConcreteStrategy1()
        {
            _field1 = default;
        }

        public ConcreteStrategy1(string field1)
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