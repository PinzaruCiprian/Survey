using eSurvey.Application.Interfaces;
using eSurvey.Domain.Entities;

namespace eSurvey.Application.Queries.SurveyTemplateQueries
{
    public class GetAllTemplatesQuery : IQuery<ICollection<SurveyTemplateItem>>
    {
    }
}
