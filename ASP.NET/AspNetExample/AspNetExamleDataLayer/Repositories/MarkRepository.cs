using AspNetExampleDomain.Entities;
using AspNetExampleDomain.Models.Student;
using AspNetExampleDomain.Repositories;

namespace AspNetExamleDataLayer.Repositories
{
    public class MarkRepository : IMarkRepository
    {
        private readonly EFContext _context;

        public MarkRepository(EFContext context)
        {
            _context = context;
        }

        public async Task CreateMarkAsync(Mark mark)
        {
            await _context.Marks.AddAsync(mark);

            await _context.SaveChangesAsync();
        }

        public Task<GetStudentMarkResponse> GetStudentMarkAsync()
        {
            throw new NotImplementedException();
        }
    }
}
