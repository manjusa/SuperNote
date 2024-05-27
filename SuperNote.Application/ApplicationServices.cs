using Microsoft.Extensions.DependencyInjection;

namespace SuperNote.Domain;

public static class ApplicationServices
{
    public static IServiceCollection AddApplicationServices(
        this IServiceCollection services)
    {
        //Register domain services here

        return services;
    }
}