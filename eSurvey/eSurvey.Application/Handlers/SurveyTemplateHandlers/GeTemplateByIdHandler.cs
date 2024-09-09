using eSurvey.Application.Interfaces;
using eSurvey.Application.Queries.SurveyTemplateQueries;
using eSurvey.Domain.Entities;
using eSurvey.Domain.Entities.Tables;
using MediatR;
using System.Text.Json;

namespace eSurvey.Application.Handlers.SurveyHandlers
{
    public class GeTemplateByIdHandler(ITemplateRepository _templateRepository) : IRequestHandler<GetTemplateByIdQuery, SurveyTemplateItem>
     {
          public async Task<SurveyTemplateItem> Handle(GetTemplateByIdQuery request, CancellationToken cancellationToken)
          {
               SurveyTemplatesTable surveyTemplate = await _templateRepository.Get(request.TemplateId);
               return JsonSerializer.Deserialize<SurveyTemplateItem>(surveyTemplate.TemplateJson);
          }
     }
}
