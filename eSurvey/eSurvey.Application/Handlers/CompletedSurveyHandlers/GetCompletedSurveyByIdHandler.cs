using AutoMapper;
using eSurvey.Application.Interfaces;
using eSurvey.Application.Queries.CompletedSurveyQueries;
using eSurvey.Domain.Entities;
using eSurvey.Domain.Entities.Tables;
using MediatR;
using System.Text.Json;

namespace eSurvey.Application.Handlers.CompletedSurveyHandlers
{
    public class GetCompletedSurveyByIdHandler(ICompletedSurveyRepository _completedSurveyRepository, ITemplateRepository _templateRepository, IMapper _mapper) : IRequestHandler<GetCompletedSurveyByIdQuery, SurveyTemplateItem>
     {
          public async Task<SurveyTemplateItem> Handle(GetCompletedSurveyByIdQuery request, CancellationToken cancellationToken)
          {
               CompletedSurveysTable completedSurveySerialized = await _completedSurveyRepository.Get(request.SurveyId);
               CompletedSurveyItem completedSurveyDeserialized = JsonSerializer.Deserialize<CompletedSurveyItem>(completedSurveySerialized.SurveyJson);

               SurveyTemplatesTable surveyTemplateSerialized = await _templateRepository.Get(completedSurveySerialized.TemplateId);
               SurveyTemplateItem surveyTemplateDeserialized = JsonSerializer.Deserialize<SurveyTemplateItem>(surveyTemplateSerialized.TemplateJson);

               SurveyTemplateItem fullCompletedSurvey = surveyTemplateDeserialized;

               fullCompletedSurvey.Questions = completedSurveyDeserialized.Questions;

               return fullCompletedSurvey;
          }
     }
}
