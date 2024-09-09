namespace eSurvey.Domain.Entities.Tables
{
     public class UserTable
     {
          public string IDNP { get; set; }
          ICollection<CompletedSurveyItem> CompletedSurveys { get; set; }
     }
}
