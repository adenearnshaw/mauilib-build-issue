namespace MauiLibExample;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection RegisterImplementationWrapper(this IServiceCollection services)
    {
        services.AddSingleton<IImplementationWrapper,ImplementationWrapper>();
        return services;
    }
}
