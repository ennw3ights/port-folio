namespace Infrastructure.Services.DataStore.Customer.WebAppModule.Components.CreateCustomerForm;
public partial class CreateCustomerFormPublicComponent
{
    private static class Mapper
    {
        public static CustomerProperty MapToCustomerProperty(DropItem dropItem) =>
            new()
            {
                Name = dropItem.Name,
                IsRequired = dropItem.IsRequired,
                IsUnique = dropItem.IsUnique,
                IsValidByDefault = dropItem.IsValidOnly
            };

        public static CustomerDto MapToCustomerDto(CreateCustomerFormComponentModel model) =>
            new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = model.Name,
                DateTimeCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Local),
                DateTimeLastModified = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Local),
                DefaultTemplate = model.DefaultTemplate,
                Templates = model.Templates,
            };
    }
}

public partial class CreateCustomerFormPublicComponent_TemplateConstructor
{
    private static class Mapper
    {
        public static DropItem MapToDropItem(CustomerPropertyDto propertyDto) =>
            new()
            {
                Name = propertyDto.Name,
                IsValidOnly = propertyDto.IsValidOnly,
                IsRequired = propertyDto.IsRequired,
                IsUnique = propertyDto.IsUnique,
                Selector = "Available"
            };
    }
}
