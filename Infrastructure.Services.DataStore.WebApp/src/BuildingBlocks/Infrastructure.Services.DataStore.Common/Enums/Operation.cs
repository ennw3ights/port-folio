namespace Infrastructure.Services.DataStore.Common.Enums;

public sealed class Operation : SmartEnum<Operation, int>
{
    public static readonly Operation MoreThan = new("MoreThan", 1);
    public static readonly Operation MoreOrEqualThan = new("MoreOrEqualThan", 2);
    public static readonly Operation Equal = new("Equal", 3);
    public static readonly Operation LessOrEqualThan = new("LessOrEqualThan", 4);
    public static readonly Operation Contains = new("Contains", 5);
    public static readonly Operation StartWith = new("StartWith", 6);
    public static readonly Operation EndWith = new("EndWith", 7);
    
    private Operation(string name, int value) : base(name, value)
    {
        
    }
}
