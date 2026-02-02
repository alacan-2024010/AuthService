using System.Runtime.InteropServices;
using AuthService2024010.Domain.Interfaces;
using AuthService2024010.Persistence.Data;
using AuthService2024010.Persistence.Repositories;
using Microsoft.EnttityFrameworkCore;

namespace AuthService2024010.Api.Extensions;    

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
           options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
                .UseSnakeCaseNamingConvention());

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddHealthChecks();
        
        return services;
    }

    public static IServiceCollection AddApiDocumentation(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        
        return services;
    }
    
}

