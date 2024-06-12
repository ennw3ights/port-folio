namespace Infrastructure.Services.DataStore.Common.Abstractions.Components;

public abstract class TableAbstractComponent<T> : MudTable<T>
{
    public QueryParameters QueryParameters { get; protected set; } = new QueryParameters();


    public int LastPage { get; protected set; }

    public int ItemsAmount { get; protected set; }

    public HashSet<T> SelectedRowItems { get; protected set; } = new HashSet<T>();


    public void OnSearch(string searchTerm)
    {
        QueryParameters.SearchTerm = searchTerm;
        ReloadServerData();
    }

    public void OnTypeChanged(IEnumerable<string> sourceTypeNames)
    {
        QueryParameters.SourceTypeNames = sourceTypeNames;
        ReloadServerData();
    }

    public void OnPageChanged(int page)
    {
        QueryParameters.Page = page;
        ReloadServerData();
    }

    public void UpdateData(PaginatedData<T> data)
    {
        QueryParameters.Page = data.CurrentPage;
        QueryParameters.PageSize = data.PageSize;
        ItemsAmount = data.TotalCount;
        LastPage = data.TotalPages;
    }

    public void UpdateQueryParameters(TableState state)
    {
        QueryParameters.PageSize = state.PageSize;
        QueryParameters.SortColumn = state.SortLabel;
        QueryParameters.SortOrderDesc = state.SortDirection == SortDirection.Descending;
    }

    public void UpdateQueryParameters(QueryParameters queryParameters)
    {
        QueryParameters = new QueryParameters
        {
            Page = queryParameters.Page,
            PageSize = queryParameters.PageSize,
            SearchTerm = queryParameters.SearchTerm,
            SortColumn = queryParameters.SortColumn,
            SortOrderDesc = queryParameters.SortOrderDesc
        };
    }
}
