namespace Infrastructure.Services.DataStore.Customer.WebAppModule.Components.CustomerInfoForm;
public partial class CustomerInfoFormPublicComponent
{
    private static class Mapper
    {
        public static CustomerInfoFormComponentModel MapToModel(CustomerDto customerDto) =>
            new()
            {
                Id = customerDto.Id,
                Name = customerDto.Name,
                DateTimeCreate = customerDto.DateTimeCreated,
                DateTimeLastModified = customerDto.DateTimeLastModified,
                DefaultTemplate = customerDto.DefaultTemplate,
                Templates = customerDto.Templates,
            };

        public static CustomerDto MapToDto(CustomerInfoFormComponentModel model) =>
            new()
            {
                Id = model.Id,
                Name = model.Name,
                DateTimeCreated = model.DateTimeCreate, 
                DateTimeLastModified = model.DateTimeLastModified,
                DefaultTemplate = model.DefaultTemplate,
                Templates = model.Templates
            };
    }
}
