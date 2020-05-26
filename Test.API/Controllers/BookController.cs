using System.Threading.Tasks;
using Convey.CQRS.Commands;
using Convey.CQRS.Queries;
using Microsoft.AspNetCore.Mvc;
using Test.Application.Commands;
using Test.Application.Queries;
using Test.Application.Queries.DTO;

namespace Test.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IQueryDispatcher _queryDispatcher;

        public BookController(ICommandDispatcher commandDispatcher,IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        [HttpPost]
        public async Task<IActionResult> AddBookAsync()
        {
            await _commandDispatcher.SendAsync(new AddBookCommand("master of war","Tom Ridle"));
            return  new OkResult();
        }

        [HttpGet]
        public async Task<IActionResult> GetBookAsync()
        {
            var response= await _queryDispatcher.QueryAsync(new GetBookQuery("whatever"));
            return new OkObjectResult(response);
        }
    }
}