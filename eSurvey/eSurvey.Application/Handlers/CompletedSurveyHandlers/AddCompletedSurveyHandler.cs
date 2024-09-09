using eSurvey.Application.Commands.CompletedSurveyCommand;
using eSurvey.Application.Interfaces;
using eSurvey.Domain.Entities.Tables;
using MediatR;
using Shared.UnitOfWork;
using System.Text.Json;

namespace eSurvey.Application.Handlers.CompletedSurveyHandlers
{
    public class AddCompletedSurveyHandler(ICompletedSurveyRepository _completedSurveyRepository, IUnitOfWork _unitOfWork) : IRequestHandler<AddCompletedSurveyCommand>
     {
          public async Task Handle(AddCompletedSurveyCommand request, CancellationToken cancellationToken)
          {
               CompletedSurveysTable completedSurvey = new()
               {
                    Id = Guid.NewGuid().ToString(),
                    TemplateId = request.TemplateId,
                    UserIDNP = request.UserIDNP,
                    SurveyJson = JsonSerializer.Serialize(request.Survey)
               };

               await _completedSurveyRepository.Add(completedSurvey);
               await _unitOfWork.SaveChangesAsync(cancellationToken);
          }
     }
}
