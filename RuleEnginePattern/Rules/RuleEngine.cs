using System.Collections;
using System.Collections.Generic;
using RuleEnginePattern.Contexts;
using RuleEnginePattern.Rules.Abstractions;

namespace RuleEnginePattern
{
    /// <summary>
    /// Tiene la responsabilidad de procesar un conjunto de reglas y 
    /// aplicar estas para producir un resultado.
    /// 
    /// Permisas:
    /// - Gestiona el conjunto de reglas.
    /// - Selecciona las reglas a aplicar.
    /// - Las reglas pueden ser ordenadas, agregadas y filtradas 
    ///   según y como se necesite.
    /// </summary>
    public class RuleEngine
    {
        private readonly List<IRule>  _rules;

        public RuleEngine(IEnumerable<IRule> rules)
        {
            // Guard clauses

            _rules = new List<IRule>();
            _rules.AddRange(rules);
        }

        public Result Apply(Context1 context)
        {
            Result result = Result.Zero;
            foreach (var rule in _rules)
            {
                result = rule.Evaluate("parameter1");
            }

            return result;
        }
    }
}