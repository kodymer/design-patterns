using System.ComponentModel;
using StrategyPattern.ConcreteStrategies;
using StrategyPattern.Contexts;
using StrategyPattern.Strategies.Abstractions;

namespace StrategyPattern
{
    class Program
    {
        /// <summary>
        /// Strategy: Es un patrón de diseño de comportamiento que te permite
        /// definir una familia de algoritmos, colocar cada uno de ellos en
        /// una clase separada y hacer sus objetos intercambiables.
        /// Tambien llamado "Policy Pattern". Sugiere que tomes esa clase 
        /// que hace algo específico de muchas formas diferentes y extraidas
        /// todos esos algoritmos para colocarlos en clases separadas llamadas 
        /// estrategias.
        /// Incrementa la posibilidad de testear nuestra aplicación al permitir
        /// realizar mock/fake implementation de las estrategias.
        /// 
        /// Colaboradores: Strategy, Context 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            ///******************************************************** 
            /// Dynamic Strategy
            /// 

            /// 
            /// Una implementación concreta de la estrategia, debe ser 
            /// seleccionada ségun el coportamiento del usurio en
            /// el runtime y luego ésta, debe ser asignada al contexto
            /// 

            var strategy = SelectStrategy(1);

            var context = new Context1(strategy);
            context.DoSomething();

            strategy = SelectStrategy(2);
            context.Set(strategy);
            context.DoSomething();

            ///******************************************************** 
            /// Static Strategy
            /// 

            context = new Context1<ConcreteStrategy1>();
            context.DoSomething();

            context = new Context1<ConcreteStrategy2>();
            context.DoSomething();

            context = new Context1<ConcreteStrategy3>();
            context.DoSomething();


            /// 
            /// Tambien se puede pasar una estrategia durante la llamada de
            /// un método, como por ejemplo ocurre con Array.Sort() y la interfaz
            /// IComparer
            /// 

            strategy = SelectStrategy(3);
            Context2.DoSomething("value1", strategy);
        }

        private static IStrategy SelectStrategy(int option)
        {
            return option switch
            {
                1 => new ConcreteStrategy1(),
                2 => new ConcreteStrategy2(),
                _ => new ConcreteStrategy3()
            };
        }

    }
}
