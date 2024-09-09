using Shared.EntityBase;

namespace eSurvey.Domain.Entities.Tables
{
    public class SurveyTemplatesTable : EntityBase
    {
        public string TemplateJson { get; set; }
        public ICollection<CompletedSurveysTable> CompletedSurveys { get; set; }
    }
}
