using Student.API.DataAccess.Interfaces;
using Student.API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.API.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentDataService studentDataService;

        public StudentService(IStudentDataService studentDataService)
        {
            this.studentDataService = studentDataService;
        }

        public async Task<IEnumerable<Student>> Get()
        {
            return await studentDataService.Get();
        }
    }
}
