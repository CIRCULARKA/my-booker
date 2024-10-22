namespace MyBooker.Api.Extensions;

public static class AddMyBookerStorageExtension
{
    /// <summary>
    /// Adds dependencies in order to enable relational storage for the service
    /// </summary>
    public static IServiceCollection AddMyBookerStorage(this IServiceCollection services, AppConfiguration config)
    {
        ArgumentNullException.ThrowIfNull(config);

        if (string.IsNullOrWhiteSpace(config.DbConnectionString))
            throw new InvalidOperationException($"{nameof(config.DbConnectionString)} option must be specified");

        services.AddDbContext<MyBookerDbContext>(opts =>
        {
            opts.UseNpgsql(config.DbConnectionString);
            opts.UseSnakeCaseNamingConvention();
        });

        return services;
    }
}
