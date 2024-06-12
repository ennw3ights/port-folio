namespace Infrastructure.Services.DataStore.Common.Models;

public class PaginatedData<T>(
    List<T> data,
    int totalCount,
    int currentPage,
    int pageSize)
{
    public List<T> Data { get; set; } = data;
    public int TotalCount { get; set; } = totalCount;
    public int CurrentPage { get; set; } = currentPage;
    public int PageSize { get; set; } = pageSize;
    public int TotalPages { get; } = (int)Math.Ceiling((double)totalCount / pageSize);
    public bool HasPreviousPage => CurrentPage > 1;
    public bool HasNextPage => CurrentPage < TotalPages;
}
