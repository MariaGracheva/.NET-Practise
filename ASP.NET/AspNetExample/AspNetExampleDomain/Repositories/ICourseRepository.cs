
using AspNetExampleDomain.Entities;
using AspNetExampleDomain.Models.Course;

namespace AspNetExampleDomain.Repositories
{
    public interface ICourseRepository
    {
        Task CreateCourseAsync(Course course);

        Task<GetCourseResponse> GetCourseAsync(Guid id);
    }
}
