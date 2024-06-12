namespace Infrastructure.Services.DataStore.Customer.WebAppModule.Components.CustomerTable;

public partial class CustomerTablePublicComponent
{
    private static class Mapper
    {
        public static PaginatedData<CustomerTableComponentModel.CustomerItem> MapToTableData(
            PaginatedData<CustomerDto> data) =>
            new(currentPage: data.CurrentPage,
                pageSize: data.PageSize,
                totalCount: data.TotalCount,
                data: data.Data.Select(MapToItem).ToList());

        private static CustomerTableComponentModel.CustomerItem MapToItem(CustomerDto dto) =>
            new()
            {
                Id = dto.Id,
                Name = dto.Name,
                DateTimeCreate = dto.DateTimeCreated,
                DateTimeLastModified = dto.DateTimeLastModified,
            };
    }
}
