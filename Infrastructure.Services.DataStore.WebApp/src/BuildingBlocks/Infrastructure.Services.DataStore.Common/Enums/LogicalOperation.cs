namespace Infrastructure.Services.DataStore.Common.Enums;

public sealed class LogicalOperation : SmartEnum<LogicalOperation, int>
{
    public static readonly LogicalOperation Conjunction = new("AND", 1);
    public static readonly LogicalOperation Disjunction = new("OR", 2);
    
    private LogicalOperation(string name, int value) : base(name, value)
    {
        
    }
}
