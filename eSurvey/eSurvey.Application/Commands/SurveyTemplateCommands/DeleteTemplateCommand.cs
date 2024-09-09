using eSurvey.Application.Interfaces;
using MediatR;

namespace eSurvey.Application.Commands.SurveyTemplateCommands
{
    public class DeleteTemplateCommand : ICommand
    {
        public string TemplateId { get; set; }
    }
}
