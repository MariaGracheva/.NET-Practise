using AspNetExampleDomain.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetExampleDomain.Models.Course
{
    public class GetCourseResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public IEnumerable<GetStudentResponse> Students { get; set; }
    }
}
