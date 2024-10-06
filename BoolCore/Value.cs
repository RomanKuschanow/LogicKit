namespace BoolCore;
public class Value(bool value) : IExpression
{
    private readonly bool _value = value;

    public bool GetValue() => _value;
}
