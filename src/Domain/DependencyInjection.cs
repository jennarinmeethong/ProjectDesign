global using ProjectDesign.Domain.Entities;
global using ProjectDesign.Domain.Interfaces;
// global using ProjectDesign.Domain.Requests;
// global using ProjectDesign.Domain.Responses;
global using Microsoft.EntityFrameworkCore;
global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.DependencyInjection;

namespace ProjectDesign;

public static class DependencyInjection
{
    public static IServiceCollection AddDomainServices(this IServiceCollection services)
    {
        return services;
    }
}
