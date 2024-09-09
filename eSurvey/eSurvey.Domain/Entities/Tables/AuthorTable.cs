namespace eSurvey.Domain.Entities.Tables
{
     public class AuthorTable : UserTable
     {
          public ICollection<SurveyTemplateItem> CreatedTemplates { get; set; }
     }
}
