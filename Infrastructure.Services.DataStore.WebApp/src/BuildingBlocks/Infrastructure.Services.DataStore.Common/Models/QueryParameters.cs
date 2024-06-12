namespace Infrastructure.Services.DataStore.Common.Models;

public class QueryParameters
{
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 20;

    public string? SearchTerm { get; set; }
    public IEnumerable<string> SourceTypeNames { get; set; }
    public string? SortColumn { get; set; } = "Name";
    public bool SortOrderDesc { get; set; }
    public string SortOrder => SortOrderDesc ? "desc" : "asc";
}
