﻿using AspNetExampleDomain.Models.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetExampleDomain.Services
{
    public interface ICourseService
    {
        Task CreateCourseAsync(CreateCourseRequest createCourseModel);

        Task<GetCourseResponse> GetCourseAsync(Guid id);
    }
}
