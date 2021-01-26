using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.API.DataAccess.Interfaces
{
    public interface IStudentDataService
    {
        Task<IEnumerable<Student>> Get();
    }
}
