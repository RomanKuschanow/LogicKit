namespace BoolCore;
public class Variable(Func<bool> getValueFunc) : IExpression
{
    private Func<bool> GetValueFunc { get; } = getValueFunc ?? throw new ArgumentNullException(nameof(getValueFunc));

    public bool GetValue() => GetValueFunc();
}
