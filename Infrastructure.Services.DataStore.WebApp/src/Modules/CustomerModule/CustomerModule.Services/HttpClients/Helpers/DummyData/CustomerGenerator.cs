namespace CustomerModule.Services.HttpClients.Helpers.DummyData;

public static class CustomerGenerator
{
    public static CustomerDto GenerateCustomer(string id)
    {
        var templateProperties = new CustomerTemplate()
        {
            Properties = CustomerPropertyGenerator.GenerateTemplateProperties()
        };

        List<CustomerTemplate> templates = [templateProperties, templateProperties];

        var customer = new CustomerDto()
        {
            Id = id,
            Name = "Customer",
            DateTimeCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Local),
            DateTimeLastModified = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Local),
            DefaultTemplate = new CustomerTemplate()
            {
                Properties = CustomerPropertyGenerator.GenerateTemplateProperties()
            },
            Templates = templates,
        };

        return customer;
    }

    public static List<CustomerDto> GenerateCustomerList()
    {
        var dummyData = new List<CustomerDto>();

        for (int i = 0; i < 30; i++)
        {
            dummyData.Add(new CustomerDto()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Customer" + i,
                DateTimeCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Local),
                DateTimeLastModified = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Local),
                DefaultTemplate = new CustomerTemplate(),
                Templates = new List<CustomerTemplate>()
            });
        }

        return dummyData;
    }
}
