using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace eSurvey.Application
{
     public static class DependencyInjection
     {
          public static IServiceCollection AddApplication(this IServiceCollection services)
          {
               services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
               //services.AddControllersWithViews().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<ValidatorAssemblyMaker>());
               services.AddAutoMapper(typeof(MappingProfile));
               return services;
          }
     }
}
