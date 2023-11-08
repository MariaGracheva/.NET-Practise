using AspNetExampleDomain.Models.Mark;
using AspNetExampleDomain.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetExample.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class MarkController : ControllerBase
    {
        private readonly IMarkService _markService;

        public MarkController(IMarkService markService)
        {
            _markService = markService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task <IActionResult> CreateMark([FromBody] CreateMarkRequest createMarkRequest)
        {
            await _markService.CreateMarkAsync(createMarkRequest);

            return Ok();
        }
    }
}
