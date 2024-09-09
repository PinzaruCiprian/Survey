using eSurvey.Application.Commands.SurveyTemplateCommands;
using eSurvey.Application.Interfaces;
using MediatR;
using Shared.UnitOfWork;

namespace eSurvey.Application.Handlers.SurveyHandlers
{
    public class DeleteTemplateHandler(ITemplateRepository _templateRepository, IUnitOfWork _unitOfWork) : IRequestHandler<DeleteTemplateCommand>
     {
          public async Task Handle(DeleteTemplateCommand request, CancellationToken cancellationToken)
          {
               await _templateRepository.Delete(request.TemplateId);
               await _unitOfWork.SaveChangesAsync(cancellationToken);
          }
     }
}
