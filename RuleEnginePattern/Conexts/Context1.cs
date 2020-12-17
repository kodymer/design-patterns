using RuleEnginePattern.Rules;
using RuleEnginePattern.Rules.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RuleEnginePattern.Contexts
{
    public class Context1
    {

        public Result DoSometing1()
        {
            var rules = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(IRule).IsAssignableFrom(t) && !t.IsAbstract && !t.IsInterface)
                .Select(t => Activator.CreateInstance(t) as IRule);

            // Para evaluar determinadas reglas, debemos filtrar
            // éstas invocando el método IsMatch
            // 
            //   .Where(r => r.IsMatch(this));
            //
            //

            var ruleEngine = new RuleEngine(rules);

            return ruleEngine.Apply(this);

        }

        public Result DoSometing2()
        {
            var rules = new List<IRule>();
            rules.Add(new Rule1());
            rules.Add(new Rule2());

            var ruleEngine = new RuleEngine(rules);

            return ruleEngine.Apply(this);

        }
    }
}