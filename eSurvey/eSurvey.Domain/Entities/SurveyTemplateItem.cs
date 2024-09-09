using eSurvey.Domain.Entities.Tables;
using eSurvey.Domain.Enums;

namespace eSurvey.Domain.Entities
{
     public class SurveyTemplateItem
     {
          public string Name { get; set; }
          public string Description { get; set; }
          public string EligibleRespondents { get; set; }
          public string AuthorIDNP { get; set; }
          public string ServiceId { get; set; }
          public DateTime OpeningTime { get; set; }
          public DateTime ClosingTime { get; set; }
          public bool ShowIntermediateResults { get; set; }
          public bool AllowRepetitiveAnswering { get; set; }
          public bool NeedToBeSigned { get; set; }
          public ResultVisibility ResultVisibility { get; set; }
          public SurveyType Type { get; set; }
          public SurveyStatus Status { get; set; }
          public ICollection<QuestionItem> Questions { get; set; }
          public ICollection<CompletedSurveyItem> CompletedSurveys { get; set; }
     }
}
