using RuleEnginePattern.Contexts;

namespace RuleEnginePattern.Rules.Abstractions
{
    public abstract class Rule : IRule
    {
        public abstract Result Evaluate(string parameter1);

        public virtual bool IsMatch(Context1 context) => true;
        
    }
}