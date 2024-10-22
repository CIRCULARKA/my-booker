namespace MyBooker.Api.Extensions;

public static class GetAppConfigurationExtension
{
    /// <summary>
    /// Gets application's configuration object
    /// </summary>
    public static AppConfiguration GetAppConfiguration(this IHostApplicationBuilder builder)
    {
        var result = builder.Configuration.Get<AppConfiguration>();

        if (result is null)
            throw new InvalidOperationException("Configuration wasn't loaded");

        return result;
    }
}
