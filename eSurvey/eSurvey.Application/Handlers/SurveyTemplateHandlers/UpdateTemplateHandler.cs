using eSurvey.Application.Commands.SurveyTemplateCommands;
using eSurvey.Application.Interfaces;
using eSurvey.Domain.Entities.Tables;
using MediatR;
using Shared.UnitOfWork;
using System.Text.Json;

namespace eSurvey.Application.Handlers.SurveyHandlers
{
    public class UpdateTemplateHandler(ITemplateRepository _templateRepository, IUnitOfWork _unitOfWork) : IRequestHandler<UpdateTemplateCommand>
     {
          public async Task Handle(UpdateTemplateCommand request, CancellationToken cancellationToken)
          {
               string json = JsonSerializer.Serialize(request.Template);

               SurveyTemplatesTable surveyTemplate = await _templateRepository.Get(request.TemplateId);
               surveyTemplate.TemplateJson = json;

               await _templateRepository.Update(surveyTemplate);
               await _unitOfWork.SaveChangesAsync(cancellationToken);
          }
     }
}
