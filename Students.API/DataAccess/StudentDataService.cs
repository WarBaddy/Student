using Student.API.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Linq;
using Dapper;

namespace Student.API.DataAccess
{
    public class StudentDataService : IStudentDataService
    {
        private readonly IDbConnectionFactory dbConnectionFactory;
        public StudentDataService(IDbConnectionFactory dbConnectionFactory)
        {
            this.dbConnectionFactory = dbConnectionFactory;
        }
        public async Task<IEnumerable<Student>> Get()
        {
            using (var connection = dbConnectionFactory.GetConnection())
            {
                string sql = "SELECT * FROM dbo.Student ORDER BY studentID DESC";
                var queryResult = await connection.QueryAsync<Student>(sql);
                return queryResult;
            }
        }
    }
}
