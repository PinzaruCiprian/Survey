using eSurvey.Domain.Entities.Tables;
using Shared.Repository;

namespace eSurvey.Application.Interfaces
{
    public interface ITemplateRepository : IRepository<SurveyTemplatesTable>
     {
     }
}
