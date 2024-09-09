using Shared.EntityBase;

namespace eSurvey.Domain.Entities.Tables
{
    public class ServiceTable : EntityBase
    {
        public ICollection<SurveyTemplateItem> Templates { get; set; }
    }
}
