namespace Infrastructure.Services.DataStore.App.BuilderExtensions;

public static class HttpClientConfigurationBuilderExtension
{
    public static void RegisterServices(this WebApplicationBuilder builder)
    {
        builder.SetupHttpClientConfiguration();
    }

    private static void SetupHttpClientConfiguration(this WebApplicationBuilder builder)
    {
        builder.Services.AddHttpContextAccessor();

        string? baseAddressUrl = builder.Configuration["HttpClientSettings:BaseAddressUrl"];
        string backendHttpClientName = builder.Configuration["HttpClientSettings:BackendHttpClientName"];

        builder.Services.AddHttpClient(
            backendHttpClientName!,
            client =>
            {
                if (baseAddressUrl != null)
                {
                    client.BaseAddress = new Uri(baseAddressUrl);
                }
            });

        builder.Services.AddTransient(sp => sp
            .GetRequiredService<IHttpClientFactory>()
            .CreateClient(backendHttpClientName!));
    }
}
