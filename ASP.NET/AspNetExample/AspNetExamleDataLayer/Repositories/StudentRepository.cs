using AspNetExampleBusinesLayer.Services.Repositories;
using AspNetExampleDomain.Entities;
using AspNetExampleDomain.Models.Mark;
using AspNetExampleDomain.Models.Student;
using Microsoft.EntityFrameworkCore;

namespace AspNetExamleDataLayer.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly EFContext _context;

        public StudentRepository(EFContext context)
        {
            _context = context;
        }

        public async Task AddStudentToCourse(Guid studentId, Guid courseId)
        {
            var student = await _context.Students.FirstOrDefaultAsync(s => s.Id == studentId);

            var course = await _context.Courses.Include(s=> s.Students).FirstOrDefaultAsync(s => s.Id == courseId);

            course.Students.Add(student);

            await _context.SaveChangesAsync();
        }

        public async Task CreateStudentAsync(Student student)
        {
            await _context.AddAsync(student);

            await _context.SaveChangesAsync();
        }

        public async Task<GetStudentMarkResponse> GetGetStudentMarkAsync(Guid studentId)
        {
            return await _context.Students
                .Where(s => s.Id == studentId)
                .Select(s => new GetStudentMarkResponse
                {
                    Name = s.Name,
                    Surname = s.Surname,
                    Marks = s.Marks.Select(m => new GetMarkResponse
                    {
                        Value = m.Value,
                        CourseId = m.CourseId,
                        CourseName = m.Course.Name,
                        CourseDate = m.Course.Date

                    })
                }).SingleOrDefaultAsync();

        }

        public async Task<Student> GetStudentAsync(Guid id)
        {
            return await _context.Students.SingleOrDefaultAsync(s => s.Id == id);
        }

        public async Task<Student[]> GetStudentsSAsync()
        {
            return await _context.Students.ToArrayAsync();
        }

        public async Task<bool> StudentHasBeenRegisteredToCourse(Guid studentId, Guid courseId)
        {
            var course = await _context.Courses.Include(s => s.Students).FirstOrDefaultAsync(s => s.Id == courseId);

            return course.Students.Any(s => s.Id == studentId);
        }

        public async Task UpdateStudentAsync(Student student)
        {
            _context.Update(student);

            await _context.SaveChangesAsync();
        }
    }
}
