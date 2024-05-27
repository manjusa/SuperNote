using Microsoft.Extensions.DependencyInjection;

namespace SuperNote.Domain;

public static class DomainServices
{
    public static IServiceCollection AddDomainServices(
        this IServiceCollection services)
    {
        //Register domain services here

        return services;
    }
}