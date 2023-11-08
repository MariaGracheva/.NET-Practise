using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetExampleDomain.Models.Mark
{
    public class CreateMarkRequest
    {
        public ushort Value { get; set; }

        public Guid StudentId { get; set; }

        public Guid CourseId { get; set; }
    }
}
