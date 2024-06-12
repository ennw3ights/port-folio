namespace SourceModule.WebAppModule.Components.SourceTable;

public partial class SourceTablePublicComponent
{
    private static class Mapper
    {
        public static PaginatedData<SourceTableComponentModel.SourceItem> MapToTableData(
            PaginatedData<SourceDto> data) =>
            new(currentPage: data.CurrentPage,
                pageSize: data.PageSize,
                totalCount: data.TotalCount,
                data: data.Data.Select(MapToItem).ToList());

        private static SourceTableComponentModel.SourceItem MapToItem(SourceDto dto) =>
            new()
            {
                Id = dto.Id,
                Name = dto.Name,
                Type = dto.Type,
                DateTimeCreate = dto.DateTimeCreate,
                DateTimeModified = dto.DateTimeModified,
                Template = dto.Template,
            };
    }
}
