using eSurvey.Application.Commands.CompletedSurveyCommand;
using eSurvey.Application.Queries.CompletedSurveyQueries;
using eSurvey.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace eSurvey.WebApi.Controllers
{
     [ApiController]
     [Route("[controller]")]
     public class CompletedSurveyController(IMediator mediator) : ControllerBase
     {
          [HttpPost("CreateCompletedSurvey")]
          public async Task<IActionResult> CreateCompletedSurvey(string templateId, string userIDNP, CompletedSurveyItem item)
          {
               await mediator.Send(new AddCompletedSurveyCommand()
               {
                    TemplateId = templateId,
                    UserIDNP = userIDNP,
                    Survey = item
               });
               return Ok(item);
          }

          [HttpGet("GetCompletedSurveyById")]
          public async Task<IActionResult> GetCompletedSurveyById(string id)
          {
               return Ok(await mediator.Send(new GetCompletedSurveyByIdQuery() { SurveyId = id }));
          }

          [HttpGet("GetAllCompletedSurveys")]
          public async Task<IActionResult> GetAllCompletedSurveys()
          {
               return Ok(await mediator.Send(new GetAllCompletedSurveysQuery()));
          }
     }
}
