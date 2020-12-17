using StrategyPattern.Strategies.Abstractions;

namespace StrategyPattern.Contexts
{
    /// <summary>
    /// El rol que juega el contexto en el patrón, es el de tener 
    /// un campo para almacenar una referencia a una de las 
    /// estrategias (<see cref="IStrategy"/>) y delega el trabajo
    /// a un objeto de estrategia vinculado en lugar de ejecutarlo
    /// por su cuenta.
    /// 
    /// El contexto no es responsable de seleccionar un algoritmo 
    /// adecuado para la tarea. De hecho, la clase contexto no sabe 
    /// mucho acerca de las estrategias.
    /// Funciona con todas las estrategias a través de la misma interfaz
    /// genérica, que sólo expone un único método para disparar el 
    /// algoritmo encapsulado dentro de la estrategia seleccionada.
    /// </summary>
    public class Context1
    {
        protected IStrategy Strategy { get; set; }

        ///
        /// Opción #1: Asignar una estrategia por constructor
        /// 

        public Context1(IStrategy strategy = null)
        { 
            // Guard clauses

            Strategy = strategy;
        }

        ///
        /// Opción #2: Asignar una estrategia a traves de un 
        /// método de asignación
        /// 
        /// Variación llamada "Dynamic Strategy"
        /// 

        public void Set(IStrategy strategy)
        {
            // Guard clauses

            Strategy = strategy;
        }


        public virtual void DoSomething()
        {
            Strategy.DoSomething(this);
        }

    }

    ///
    /// Opción #3: Asignar una estrategia a traves de parametro 
    /// de tipo en una clase genérica
    /// 
    /// Variación llamada "Static Strategy"
    ///
    public class Context1<TStrategy> : Context1
        where TStrategy : class, IStrategy, new()
    {

        public Context1()
        {
            Strategy = new TStrategy();
        }

        public override void DoSomething()
        {

            Strategy.DoSomething(this);
        }

    }
}