namespace Infrastructure.Services.DataStore.Search.Models.Components;

public class PaginationAndSortingSourceComponentModel
{
    public List<PaginationAndSortingSource> SelectedProperties { get; set; } = [];

    public class PaginationAndSortingSource
    {
        public string Name { get; set; } = null!;
        public bool Selected { get; set; }
    }
}
