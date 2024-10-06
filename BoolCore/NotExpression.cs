namespace BoolCore;
public class NotExpression(IExpression expression) : IExpression
{
    public IExpression Expression { get; } = expression;

    public bool GetValue() => !Expression.GetValue();
}
