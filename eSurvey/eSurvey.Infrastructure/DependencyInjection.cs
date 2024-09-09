using eSurvey.Application.Interfaces;
using eSurvey.Domain.Entities.Tables;
using eSurvey.Infrastructure.ApplicationDbContext;
using eSurvey.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shared.Repository;
using Shared.UnitOfWork;

namespace eSurvey.Infrastructure
{
    public static class DependencyInjection
     {
          public static IServiceCollection AddInfrastructure(this IServiceCollection services, string? connectionString)
          {
               services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

               services.AddScoped<IRepository<SurveyTemplatesTable>, RepositoryBase<SurveyTemplatesTable, AppDbContext>>();
               services.AddScoped<ITemplateRepository, TemplateRepository>();

               services.AddScoped<IRepository<CompletedSurveysTable>, RepositoryBase<CompletedSurveysTable, AppDbContext>>();
               services.AddScoped<ICompletedSurveyRepository, CompletedSurveyRepository>();

               services.AddScoped<IUnitOfWork, UnitOfWork<AppDbContext>>();
               return services;
          }
     }
}
