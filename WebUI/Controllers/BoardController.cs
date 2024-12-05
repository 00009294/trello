using Application.Features.Boards;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private readonly IMediator mediator;
        public BoardController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddBoard(AddBoardCommand command)
        {
            if(ModelState.IsValid)
            {
                var result = await this.mediator.Send(command);
                
                return Ok(result);
            }

            return BadRequest(new
            {
                IsSuccessful = false,
                Errors = ModelState.Values
                    .SelectMany(a => a.Errors)
                    .Select(a => a.ErrorMessage)
            });

        }
    }
}
