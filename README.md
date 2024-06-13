Advice - проекты
Рабоотал над двумя модулями:
1) Notification - модуль уведомлений, в этом проекте работал над кнопкой, которая показывает количество уведомлений и Badge, если есть уведомления.

Http-клиент с Dummy-данными:

```csharp
public class NotificationHttpClient() : INotificationHttpClient
{
    //Пока что стоит заглушка, поэтому предупреждение игнорируется
    public async Task<NotificationDto> GetAsync(CancellationToken cancellationToken = default)
    {
        await Task.Delay(100, cancellationToken);

        var notificationDto = new NotificationDto()
        {
            Count = 70,
        };

        return notificationDto;
    }
}
```

Сервис для работы с Http-клиентом:

```csharp
public class NotificationService(INotificationHttpClient httpClient) : INotificationHttpClient
{
    public async Task<NotificationDto> GetAsync(CancellationToken cancellationToken = default)
    {
        NotificationDto response = await httpClient.GetAsync(cancellationToken);

        return response;
    }
}
```

Код компонента:

```csharp
<MudButton 
    OnClick="@OnNotificationButtonClick">
    @if (IsNotified)
    {
        <MudBadge Overlap="true">
            <MudIcon Icon="@Icons.Material.Outlined.Notifications" />
        </MudBadge>
    }
    else
    {
        <MudIcon />
    }
    <MudText>@_notificationCountText</MudText>
</MudButton>

@code {
    NotificationCountIconComponentModel _notificationCountIconComponentModel = new NotificationCountIconComponentModel();

    bool IsNotified => _notificationCountIconComponentModel.Count != 0;

    string _notificationCountText = string.Empty;
    
    const string DefaultTextIfCountExceed = "99+";
    const int MaxCount = 99;

    void SetNotificationCount()
    {
        _notificationCountText = _notificationCountIconComponentModel.Count > MaxCount 
            ? DefaultTextIfCountExceed 
            : _notificationCountIconComponentModel.Count.ToString();
    }

    async Task GetNotificationDataAsync()
    {
        var data = await NotificationHttpClient.GetAsync();

        _notificationCountIconComponentModel = Mapper.MapToModel(data);

        SetNotificationCount();
    }

    protected override async Task OnInitializedAsync()
    {
        await GetNotificationDataAsync();
    }

    void OnNotificationButtonClick()
    {
        Snackbar.Add("Notification clicked");
    }

}
```

Задний код для компонента, содержит маппер для данных из Dto:
```csharp
public partial class NotificationCountIconPublicComponent
{
    private static class Mapper
    {
        public static NotificationCountIconComponentModel MapToModel(NotificationDto notificationDto) =>
            new()
            {
                Count = notificationDto.Count,
            };
    }
}
```

Datastore - проект для удобной работы с данными, в т.ч. их представление, создание и изменение.

Работал над двумя модулями: Customer и Source, а также некоторыми общими элементами (header/footer/theme/drawer)

1) Общие элементы:

Код для темы:
```csharp
<MudThemeProvider Theme="_dataStoreTheme"/>

@code {

    private MudTheme _dataStoreTheme = new()
    {
        Palette = new PaletteLight()
        {
            Background = new MudColor("#FFFCEF"),
            
            Primary = new MudColor("#EFDBBB"),

            Secondary = new MudColor("#DFC4A4"),

            TableLines = new MudColor("#C79667"),

            TextPrimary = new MudColor("#634B4F"),
        },

        Typography = new Typography()
        {
            H1 = new H1()
            {
                FontFamily = new[] { "Merriweather" },
                FontWeight = 400,
                FontSize = "27px"
            },
            H2 = new H2()
            {
                FontFamily = new[] { "Harmattan" },
                FontWeight = 400,
                FontSize = "20px"
            },
            Body1 = new Body1()
            {
                FontFamily = new[] { "Harmattan" },
                FontWeight = 400,
                FontSize = "16px"
            },
            Body2 = new Body2()
            {
                FontFamily = new[] { "Harmattan" },
                FontWeight = 400,
                FontSize = "14px"
            },
        }
    };
}
```

Код для сервиса логгирования, который также выводит Snackbar:
```csharp
public class LoggingService(ISnackbar snackbar, ILogger<LoggingService> logger)
    : ILoggingService
{
    private readonly ISnackbar _snackbar = snackbar;
    private readonly ILogger<LoggingService> _logger = logger;

    public void LogError(string message, Exception exception)
    {
        _logger.LogError(exception, "{Message}: {ExceptionMessage}", message, exception);

        _snackbar.Add(message, Severity.Error);
    }

    public void LogSuccess(string Message)
    {
        _logger.LogInformation("{Message}", Message);

        _snackbar.Add(Message, Severity.Success);
    }
}
```

Enum для Source Type:
```csharp
public sealed class SourceType : SmartEnum<SourceType, int>
{
    public static readonly SourceType ManualLoading = new("Manual Loading", 1);
    public static readonly SourceType AutoLoading = new ("Auto Loading", 2);

    private SourceType(string name, int value) : base(name, value)
    {
        
    }
}
```

Код для абстрактной таблицы:
```csharp
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
```

2) Customer

Http-клиент для работы с Customer модулем:
```csharp
public class CustomerHttpClient : ICustomerHttpClient
{
    public async Task<List<CustomerPropertyDto>> GetAvailablePropertiesAsync(CancellationToken cancellationToken = default)
    {
        await Task.Delay(200, cancellationToken);
        List<CustomerPropertyDto> response = CustomerPropertyGenerator.GenerateDummyProperties();

        return response;
    }

    public async Task CreateAsync(CustomerDto customerDto, CancellationToken cancellationToken = default)
    {
        await Task.Delay(200, cancellationToken);
    }

    public async Task DeleteAsync(string id, CancellationToken cancellationToken = default)
    {
        await Task.Delay(200, cancellationToken);
    }

    public async Task UpdateAsync(CustomerDto customerDto, CancellationToken cancellationToken = default)
    {
        await Task.Delay(200, cancellationToken);
    }

    public async Task<CustomerDto> GetCustomerAsync(string id, CancellationToken cancellationToken = default)
    {
        await Task.Delay(200, cancellationToken);
        CustomerDto response = CustomerGenerator.GenerateCustomer(id);

        return response;
    }

    public async Task<PaginatedData<CustomerDto>> GetAsync(QueryParameters queryParameters, CancellationToken cancellationToken = default)
    {
        await Task.Delay(200, cancellationToken);
        List<CustomerDto> DummyDto = CustomerGenerator.GenerateCustomerList();
        var data = new PaginatedData<CustomerDto>(DummyDto, DummyDto.Count, queryParameters.Page,
            queryParameters.PageSize);
        return data;
    }
}
```

Валидация для названия Customer:
```csharp
public class CustomerValidator : ICustomerValidator
{
    public IEnumerable<string> ValidateName(string customerName)
    {
        if (string.IsNullOrWhiteSpace(customerName))
        {
            yield return "Source name is required!";
            yield break;
        }

        if (customerName.Length < 3)
        {
            yield return "Source name must be at least of length 3";
        }

        if (customerName.Length > 100)
        {
            yield return "The length of the source name should not exceed 100";
        }
    }
}
```

Код для таблциы Customer:
```csharp
inject ICustomerHttpClient CustomerHttpClient

<CustomerTable
    SortLabel="Sort By"
    Bordered="true"
    @ref="_table"
    ServerData="@(new Func<TableState, Task<TableData<CustomerTableComponentModel.CustomerItem>>>(ServerReload))">
    
    <ToolBarContent>
        <CustomerTablePublicComponent_Search OnSearch="@(_table.OnSearch)"/>
        <MudSpacer />
        <MudButton Href="/create-customer">Create a customer</MudButton>
    </ToolBarContent>
    
    <HeaderContent>
        <MudTh>Name of customer</MudTh>
        <MudTh>
            <MudTableSortLabel SortBy="new Func<CustomerTableComponentModel.CustomerItem, object>(x=>x.DateTimeCreate)"
                               SortLabel="DateTimeCreate"
                               T="CustomerTableComponentModel.CustomerItem">
                Creation date
            </MudTableSortLabel>
        </MudTh>
        <MudTh>
            <MudTableSortLabel SortBy="new Func<CustomerTableComponentModel.CustomerItem, object>(x=>x.DateTimeLastModified)"
                               SortLabel="DateTimeModified"
                               T="CustomerTableComponentModel.CustomerItem">
                Modification date
            </MudTableSortLabel>
        </MudTh>
        <MudTh>Actions with customer</MudTh>
    </HeaderContent>
    
    <RowTemplate>
        <MudTd DataLabel="Name of customer">@context.Name</MudTd>
        <MudTd DataLabel="Creation date">@context.DateTimeCreate.ToString("dd.MM.yy")</MudTd>
        <MudTd DataLabel="Modification date">@context.DateTimeLastModified.ToString("dd.MM.yy")</MudTd>
        <MudTd DataLabel="Actions with customer">
            <MudLink Href="">Open</MudLink>
            <MudLink Href="">Export</MudLink>
        </MudTd>
    </RowTemplate>
</CustomerTable>

@code {
    CustomerTable<CustomerTableComponentModel.CustomerItem> _table = new();

    async Task<TableData<CustomerTableComponentModel.CustomerItem>> ServerReload(TableState state)
    {
        _table.UpdateQueryParameters(state);

        var response = await CustomerHttpClient.GetAsync(_table.QueryParameters);

        var tableData = Mapper.MapToTableData(response);

        _table.UpdateData(tableData);

        await InvokeAsync(StateHasChanged);

        return new TableData<CustomerTableComponentModel.CustomerItem>()
        {
            TotalItems = tableData.TotalCount,
            Items = tableData.Data,
        };
    }
}
```
