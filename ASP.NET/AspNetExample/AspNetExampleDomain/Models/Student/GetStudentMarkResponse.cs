using AspNetExampleDomain.Models.Mark;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetExampleDomain.Models.Student
{
    public class GetStudentMarkResponse
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public IEnumerable<GetMarkResponse> Marks { get; set; }
    }
}
