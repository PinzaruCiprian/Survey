using eSurvey.Application.Interfaces;
using eSurvey.Domain.Entities;

namespace eSurvey.Application.Queries.SurveyTemplateQueries
{
    public class GetTemplateByIdQuery : IQuery<SurveyTemplateItem>
    {
        public string TemplateId { get; set; }
    }
}
