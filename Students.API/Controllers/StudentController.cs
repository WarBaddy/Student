using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Student.API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.API.Controllers
{
    [ApiController]
    [Route("api/student")]
    public class StudentController : ControllerBase
    {

        private readonly IStudentService studentService;

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet()]
        public async Task<IEnumerable<Student>> Get()
        {
            return await studentService.Get();
        }
    }
}
