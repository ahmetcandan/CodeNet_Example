using CodeNet.Abstraction.Model;
using ExampleApi.Contract;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ExampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MongoDBController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        [Route("GetMongoDBValue")]
        [ProducesResponseType(200, Type = typeof(ResponseBase<MongoDBGetValueResponse>))]
        public async Task<IActionResult> Post([FromBody] MongoDBGetValueRequest model, CancellationToken cancellationToken)
        {
            return Ok(await mediator.Send(model, cancellationToken));
        }
    }
}
