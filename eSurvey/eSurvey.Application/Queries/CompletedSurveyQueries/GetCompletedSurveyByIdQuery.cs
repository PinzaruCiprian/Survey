using eSurvey.Application.Interfaces;
using eSurvey.Domain.Entities;

namespace eSurvey.Application.Queries.CompletedSurveyQueries
{
    public class GetCompletedSurveyByIdQuery : IQuery<SurveyTemplateItem>
    {
        public string SurveyId { get; set; }
    }
}
