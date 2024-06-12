namespace SourceModule.WebAppModule.Components.SourceInfoForm;

public partial class SourceInfoFormPublicComponent
{
    private static class Mapper
    {
        public static SourceInfoFormComponentModel MapToModel(SourceDto sourceDto) =>
            new()
            {
                Id = sourceDto.Id,
                Name = sourceDto.Name,
                Type = sourceDto.Type,
                DateTimeCreated = sourceDto.DateTimeCreate,
                DateTimeModified = sourceDto.DateTimeModified,
                Template = sourceDto.Template
            };

        public static SourceDto MapToDto(SourceInfoFormComponentModel sourceModel) =>
            new()
            {
                Id = sourceModel.Id,
                Name = sourceModel.Name,
                Type = sourceModel.Type,
                DateTimeCreate = sourceModel.DateTimeCreated,
                DateTimeModified = sourceModel.DateTimeModified,
                Template = sourceModel.Template
            };
    }
}
