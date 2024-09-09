using eSurvey.Domain.Entities.Tables;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace eSurvey.Infrastructure.ApplicationDbContext
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
     {
          public DbSet<SurveyTemplatesTable> SurveyTemplates { get; set; }
          public DbSet<CompletedSurveysTable> CompletedSurveys { get; set; }

          protected override void OnModelCreating(ModelBuilder modelBuilder)
          {
               base.OnModelCreating(modelBuilder);
               modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
          }
     }
}
