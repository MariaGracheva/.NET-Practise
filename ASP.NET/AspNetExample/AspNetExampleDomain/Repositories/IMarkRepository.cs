using AspNetExampleDomain.Entities;
using AspNetExampleDomain.Models.Mark;
using AspNetExampleDomain.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetExampleDomain.Repositories
{
    public interface IMarkRepository
    {
        Task CreateMarkAsync(Mark createMarkRequest);

        Task<GetStudentMarkResponse> GetStudentMarkAsync();
    }
}
