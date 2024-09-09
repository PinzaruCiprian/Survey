using eSurvey.Application.Interfaces;
using eSurvey.Application.Queries.SurveyTemplateQueries;
using eSurvey.Domain.Entities;
using eSurvey.Domain.Entities.Tables;
using MediatR;
using System.Text.Json;

namespace eSurvey.Application.Handlers.SurveyHandlers
{
    public class GetAllTemplatesHandler(ITemplateRepository _templateRepository) : IRequestHandler<GetAllTemplatesQuery, ICollection<SurveyTemplateItem>>
     {
          public async Task<ICollection<SurveyTemplateItem>> Handle(GetAllTemplatesQuery request, CancellationToken cancellationToken)
          {
               ICollection<SurveyTemplateItem> templatesList = new List<SurveyTemplateItem>();

               foreach (SurveyTemplatesTable surveyTemplate in await _templateRepository.Get())
               {
                    templatesList.Add(JsonSerializer.Deserialize<SurveyTemplateItem>(surveyTemplate.TemplateJson));
               }

               return templatesList;
          }
     }
}
