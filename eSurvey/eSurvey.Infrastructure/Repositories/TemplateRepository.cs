using eSurvey.Application.Interfaces;
using eSurvey.Domain.Entities.Tables;
using eSurvey.Infrastructure.ApplicationDbContext;
using Shared.Repository;

namespace eSurvey.Infrastructure.Repositories
{
    public class TemplateRepository(AppDbContext context) : RepositoryBase<SurveyTemplatesTable, AppDbContext>(context), ITemplateRepository
     {
     }
}
