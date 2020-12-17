using RuleEnginePattern.Contexts;

namespace RuleEnginePattern.Rules.Abstractions
{
    public interface IRule
    {
        Result Evaluate(string parameter1);

        /// <summary>
        /// Indica si una regla se puede aplicar o no, como resultado de una 
        /// condici�n que involucra al contexto.
        /// 
        /// Consideraciones: Este m�todo es opcional. Se utiliza siempre y 
        /// cuando el Rule Engine requiera evaluar solo aquellas reglas 
        /// que cumplan con el criterio de selecci�n.
        /// </summary>
        /// <param name="context">Conext</param>
        /// <returns>True, si la regla debe ser aplicada. De lo contrario, False</returns>
        bool IsMatch(Context1 context);
    }
}