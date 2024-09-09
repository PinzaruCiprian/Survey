using eSurvey.Application.Interfaces;
using eSurvey.Domain.Entities;

namespace eSurvey.Application.Commands.SurveyTemplateCommands
{
    public class AddTemplateCommand : ICommand
    {
        public SurveyTemplateItem Template { get; set; }
    }
}
