using eSurvey.Application.Interfaces;
using eSurvey.Domain.Entities.Tables;
using eSurvey.Infrastructure.ApplicationDbContext;
using Shared.Repository;

namespace eSurvey.Infrastructure.Repositories
{
    public class CompletedSurveyRepository(AppDbContext context) : RepositoryBase<CompletedSurveysTable, AppDbContext>(context), ICompletedSurveyRepository
     {
     }
}
