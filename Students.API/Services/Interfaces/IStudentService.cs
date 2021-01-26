using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.API.Services.Interfaces
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> Get();
    }
}
