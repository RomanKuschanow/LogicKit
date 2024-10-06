namespace BoolCore;
public class OrExpression(IExpression a, IExpression b) : IExpression
{
    public IExpression A { get; } = a;
    public IExpression B { get; } = b;

    public bool GetValue() => A.GetValue() || B.GetValue();
}
