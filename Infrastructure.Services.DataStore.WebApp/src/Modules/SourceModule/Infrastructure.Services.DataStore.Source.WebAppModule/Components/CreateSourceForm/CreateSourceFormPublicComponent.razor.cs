namespace Infrastructure.Services.DataStore.Source.WebAppModule.Components.CreateSourceForm;

public partial class CreateSourceFormPublicComponent
{
    private static class Mapper
    {
        public static CreateSourceDto MapToDto(CreateSourceFormComponentModel model) =>
            new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = model.Name,
                Type = model.Type,
                DateTimeCreate = DateTime.SpecifyKind(DateTime.Now,
                    DateTimeKind.Local),
                DateTimeModified = DateTime.SpecifyKind(DateTime.Now,
                    DateTimeKind.Local),
                Template = model.Template,
            };

    }
}
