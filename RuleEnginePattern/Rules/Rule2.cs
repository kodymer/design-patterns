using RuleEnginePattern.Rules.Abstractions;

namespace RuleEnginePattern.Rules
{
    public class Rule2 : Rule
    {
        public override Result Evaluate(string parameter1)
        {
            return Result.Two;
        }
    }
}