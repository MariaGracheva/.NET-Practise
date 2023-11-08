using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetExampleDomain.Models.Mark
{
    public class GetMarkResponse
    {
        public ushort Value { get; set; }

        public string CourseName { get; set; }

        public Guid CourseId { get; set; }

        public DateTime CourseDate { get; set; }
    }
}
