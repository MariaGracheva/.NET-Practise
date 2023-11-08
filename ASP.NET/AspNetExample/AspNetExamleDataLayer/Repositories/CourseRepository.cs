using AspNetExampleDomain.Entities;
using AspNetExampleDomain.Models.Course;
using AspNetExampleDomain.Models.Student;
using AspNetExampleDomain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AspNetExamleDataLayer.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly EFContext _context;

        public CourseRepository(EFContext context)
        {
            _context = context;
        }

        public async Task CreateCourseAsync(Course course)
        {
            await _context.AddAsync(course);

            await _context.SaveChangesAsync();
        }

        public async Task<GetCourseResponse> GetCourseAsync(Guid id)
        {
            var corses = _context.Courses.ToList();

            var courses2 = _context.Courses.Include(c => c.Students).ToList();

            return await _context.Courses
                .Where(c => c.Id == id)
                .Select(c => new GetCourseResponse 
                { 
                    Id = c.Id,
                    Capacity = c.Capacity,
                    Name = c.Name,
                    Students = c.Students.Select(s => new GetStudentResponse 
                    { 
                        Id = s.Id,
                        Name = s.Name,
                        Surname = s.Surname,
                        Age = s.Age,
                        Gender = s.Gender
                    })   
                })
                .SingleOrDefaultAsync();
        }
    }
}
