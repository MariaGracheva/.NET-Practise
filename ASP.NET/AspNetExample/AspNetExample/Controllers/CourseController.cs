using AspNetExampleDomain.Models.Course;
using AspNetExampleDomain.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetExample.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourse([FromBody] CreateCourseRequest createCourseModel)
        {
            await _courseService.CreateCourseAsync(createCourseModel);

            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<GetCourseResponse>> GetCorse(Guid id)
        {
            var courseResponse = await _courseService.GetCourseAsync(id);

            return Ok(courseResponse);
        }
    }
}
