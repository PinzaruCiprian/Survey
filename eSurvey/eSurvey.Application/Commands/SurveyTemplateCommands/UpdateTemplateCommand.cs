using eSurvey.Application.Interfaces;
using eSurvey.Domain.Entities;
using MediatR;

namespace eSurvey.Application.Commands.SurveyTemplateCommands
{
    public class UpdateTemplateCommand : ICommand
    {
        public string TemplateId { get; set; }
        public SurveyTemplateItem Template { get; set; }
    }
}
