using RuleEnginePattern.Rules.Abstractions;

namespace RuleEnginePattern.Rules
{
    /// <summary>
    /// El rol de una regla consiste en describir una condición 
    /// o calcular determinado un valor
    /// 
    /// Consideraciones:
    /// - Cada regla extraida debería tener una simple responsabilidad
    /// - Tipicamente una regla debe ser inmutable (de solo lectura)
    /// - Debemos verificar la dependencia entre reglas, y en base a eso:
    ///     * Especificar el orden de prioridad o una secuencia explicitamente
    ///     * Producir un corto circuito para que se anule la evaluación
    ///     del resto de reglas cuando sea necesario.
    /// - Las reglas que se pueden administrar con persistencia y la UI.
    /// </summary>
    public class Rule1 : Rule
    {
        public override Result Evaluate(string parameter1)
        {
            return Result.Two;
        }
    }
}