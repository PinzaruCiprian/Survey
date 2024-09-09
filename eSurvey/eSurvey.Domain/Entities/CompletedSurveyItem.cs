namespace eSurvey.Domain.Entities
{
     public class CompletedSurveyItem
     {
          public ICollection<QuestionItem> Questions { get; set; }
     }
}
