using eSurvey.Application.Interfaces;
using eSurvey.Application.Queries.CompletedSurveyQueries;
using eSurvey.Domain.Entities;
using eSurvey.Domain.Entities.Tables;
using MediatR;
using System.Text.Json;

namespace eSurvey.Application.Handlers.CompletedSurveyHandlers
{
    public class GetAllCompletedSurveysHandler(ICompletedSurveyRepository _completedSurveyRepository, ITemplateRepository _templateRepository) : IRequestHandler<GetAllCompletedSurveysQuery, ICollection<SurveyTemplateItem>>
     {
          public async Task<ICollection<SurveyTemplateItem>> Handle(GetAllCompletedSurveysQuery request, CancellationToken cancellationToken)
          {
               ICollection<SurveyTemplateItem> surveyList = new List<SurveyTemplateItem>();

               foreach (CompletedSurveysTable completedSurveySerialized in await _completedSurveyRepository.Get())
               {
                    CompletedSurveyItem completedSurveyDeserialized = JsonSerializer.Deserialize<CompletedSurveyItem>(completedSurveySerialized.SurveyJson);

                    SurveyTemplatesTable surveyTemplateSerialized = await _templateRepository.Get(completedSurveySerialized.TemplateId);
                    SurveyTemplateItem surveyTemplateDeserialized = JsonSerializer.Deserialize<SurveyTemplateItem>(surveyTemplateSerialized.TemplateJson);

                    SurveyTemplateItem fullCompletedSurvey = surveyTemplateDeserialized;
                    fullCompletedSurvey.Questions = completedSurveyDeserialized.Questions;

                    surveyList.Add(fullCompletedSurvey);
               }

               return surveyList;
          }
     }
}
