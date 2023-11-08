using AspNetExampleDomain.Entities;
using AspNetExampleDomain.Models.Course;
using AspNetExampleDomain.Repositories;
using AspNetExampleDomain.Services;

namespace AspNetExampleBusinesLayer.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task CreateCourseAsync(CreateCourseRequest createCourseModel)
        {
            var course = new Course
            {
                Id = Guid.NewGuid(),
                Name = createCourseModel.Name,
                Capacity = createCourseModel.Capacity,
                Date = createCourseModel.Date.ToUniversalTime()
            };

            await _courseRepository.CreateCourseAsync(course);
        }

        public async Task<GetCourseResponse> GetCourseAsync(Guid id)
        {
            return await _courseRepository.GetCourseAsync(id);
        }
    }
}
