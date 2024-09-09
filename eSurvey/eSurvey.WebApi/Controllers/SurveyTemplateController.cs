using eSurvey.Application.Commands.SurveyTemplateCommands;
using eSurvey.Application.Queries.SurveyTemplateQueries;
using eSurvey.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace eSurvey.WebApi.Controllers
{
     [ApiController]
     [Route("[controller]")]
     public class SurveyTemplateController(IMediator mediator) : ControllerBase
     {
          [HttpPost("CreateTemplate")]
          public async Task<IActionResult> CreateTemplate(SurveyTemplateItem item)
          {
               await mediator.Send(new AddTemplateCommand() { Template = item });
               return Ok(item);
          }

          [HttpGet("GetAllTemplates")]
          public async Task<IActionResult> GetAllTemplates()
          {
               return Ok(await mediator.Send(new GetAllTemplatesQuery()));
          }

          [HttpGet("GetTemplateById")]
          public async Task<IActionResult> GetTemplateById(string id)
          {
               return Ok(await mediator.Send(new GetTemplateByIdQuery() { TemplateId = id }));
          }

          [HttpDelete("DeleteTemplate")]
          public async Task<IActionResult> DeleteTemplate(string id)
          {
               await mediator.Send(new DeleteTemplateCommand() { TemplateId = id });
               return Ok(id);
          }

          [HttpPut("UpdateTemplate")]
          public async Task<IActionResult> UpdateTemplate(string TemplateId, SurveyTemplateItem item)
          {
               await mediator.Send(new UpdateTemplateCommand() 
               { 
                    TemplateId = TemplateId,
                    Template = item
               });
               return Ok(item);
          }
     }
}
