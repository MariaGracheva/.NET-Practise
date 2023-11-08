using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetExampleDomain.Entities
{
    /// <summary>
    /// Занятие
    /// </summary>
    public class Course
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public DateTime Date { get; set; }

        public List<Student> Students { get; set; }

        public List<Mark> Marks { get; set; }
    }
}
