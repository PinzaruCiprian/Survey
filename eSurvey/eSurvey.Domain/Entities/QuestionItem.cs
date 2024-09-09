using eSurvey.Domain.Enums;
using System.Text.Json.Serialization;

namespace eSurvey.Domain.Entities
{
     public class QuestionItem
     {
          [JsonIgnore]
          public string? QuestionId { get; set; }
          public string Title { get; set; }
          public bool AcceptsMultipleChoice { get; set; }
          public ResponseType ResponseType { get; set; }
          public ICollection<ResponseItem> Responses { get; set; }

     }
}
