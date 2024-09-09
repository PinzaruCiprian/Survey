using AutoMapper;
using eSurvey.Application.Commands.SurveyTemplateCommands;
using eSurvey.Application.Interfaces;
using eSurvey.Domain.Entities;
using eSurvey.Domain.Entities.Tables;
using MediatR;
using Shared.UnitOfWork;
using System.Text.Json;

namespace eSurvey.Application.Handlers.SurveyHandlers
{
    public class AddTemplateHandler(ITemplateRepository _templateRepository, IUnitOfWork _unitOfWork, IMapper _mapper) : IRequestHandler<AddTemplateCommand>
     {
          public async Task Handle(AddTemplateCommand request, CancellationToken cancellationToken)
          {
               foreach (QuestionItem question in request.Template.Questions)
               {
                    question.QuestionId = Guid.NewGuid().ToString();
               }

               SurveyTemplatesTable template = new SurveyTemplatesTable()
               {
                    TemplateJson = JsonSerializer.Serialize(_mapper.Map<SurveyTemplateItem>(request.Template))
               };

               await _templateRepository.Add(template);
               await _unitOfWork.SaveChangesAsync(cancellationToken);
          }
     }
}
