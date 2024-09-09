using Shared.EntityBase;

namespace eSurvey.Domain.Entities.Tables
{
    public class CompletedSurveysTable : EntityBase
    {
        public string TemplateId { get; set; }

        public string UserIDNP { get; set; }

        public string SurveyJson { get; set; }
    }
}
