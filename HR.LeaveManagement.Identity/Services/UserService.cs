using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR.LeaveManagement.Application.Models.Identity;

namespace HR.LeaveManagement.Application.Contracts.Identity
{
    public class UserService : IUserService
    {
        public Task<Employee> GetEmployee()
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
