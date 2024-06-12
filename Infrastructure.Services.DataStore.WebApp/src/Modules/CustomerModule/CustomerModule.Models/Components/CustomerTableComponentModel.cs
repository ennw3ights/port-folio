namespace CustomerModule.Models.Components;

public sealed class CustomerTableComponentModel
{
    public List<CustomerItem> Items { get; set; } = [];

    public class CustomerItem
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime DateTimeCreate { get; set; }
        public DateTime DateTimeLastModified { get; set; }
    }
}
