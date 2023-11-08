using AspNetExampleDomain.Entities;
using AspNetExampleDomain.Models.Mark;
using AspNetExampleDomain.Repositories;
using AspNetExampleDomain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetExampleBusinesLayer.Services
{
    public class MarkService : IMarkService
    {
        private readonly IMarkRepository _markRepository;

        public MarkService(IMarkRepository markRepository)
        {
            _markRepository = markRepository;
        }

        public async Task CreateMarkAsync(CreateMarkRequest createMarkRequest)
        {
            var mark = new Mark
            {
                Id = Guid.NewGuid(),
                Value = createMarkRequest.Value,
                StudentId = createMarkRequest.StudentId,
                CourseId = createMarkRequest.CourseId,

            };

            await _markRepository.CreateMarkAsync(mark);
        }
    }
}
