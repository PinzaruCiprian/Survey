using eSurvey.Application.Interfaces;
using eSurvey.Domain.Entities;

namespace eSurvey.Application.Commands.CompletedSurveyCommand
{
    public class AddCompletedSurveyCommand : ICommand
    {
        public string TemplateId { get; set; }
        public string UserIDNP { get; set; }
        public CompletedSurveyItem Survey { get; set; }
    }
}
