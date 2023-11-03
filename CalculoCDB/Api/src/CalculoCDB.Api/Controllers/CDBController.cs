using CalculoCDB.Application.Commands;
using CalculoCDB.Application.Queries.Interfaces;
using CalculoCDB.Application.Requests;
using CalculoCDB.Shared.Result.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CalculoCDB.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CDBController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ICDBQuery _query;

        public CDBController(IMediator mediator, ICDBQuery query)
        {
            _mediator = mediator;
            _query = query;
        }

        [HttpPost(), Produces("application/json", Type = typeof(IApplicationResult<Guid>))]
        public async Task<IActionResult> Contratar([FromBody] ContratarInvestimnetoCommand command) {

            return Ok(await _mediator.Send(command));
        }

        [HttpGet(), Produces("application/json", Type = typeof(IApplicationResult<Guid>))]
        public async Task<IActionResult> CalcularCDB([FromQuery] CalcularCdbRequest request)
        {
            return Ok(_query.GetCalculoCDB(request));
        }
    }
}
