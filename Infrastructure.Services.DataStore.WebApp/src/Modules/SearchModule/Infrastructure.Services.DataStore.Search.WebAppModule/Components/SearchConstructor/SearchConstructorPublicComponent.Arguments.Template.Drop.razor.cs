namespace Infrastructure.Services.DataStore.Search.WebAppModule.Components.SearchConstructor;

public partial class SearchConstructorPublicComponent_Arguments_Template_Drop
{
    private static class Mapper
    {
        private static TemplatePropertyComponentModel.TemplateProperty MapToModel(Property property) => new()
        {
            Name = property.Name,
            IsRequired = false,
            IsValid = false,
            Selector = SearchConstructorTemplatePropertySettings.AvailablePropertiesIdName
        };
        
        public static IEnumerable<TemplatePropertyComponentModel.TemplateProperty> MapToList(IEnumerable<Property> properties) =>
            properties.Select(MapToModel);
        
        private static Property MapToPropertyModel(TemplatePropertyComponentModel.TemplateProperty templateProperty) => new()
        {
            Name = templateProperty.Name,
            IsRequired = templateProperty.IsRequired,
            IsValidByDefault = templateProperty.IsValid
        };

        public static IEnumerable<Property> MapToPropertyList(IEnumerable<TemplatePropertyComponentModel.TemplateProperty> templateProperties) =>
            templateProperties.Select(MapToPropertyModel);
    }
}
