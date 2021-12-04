using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes {
    public class EmployeeService : IEmployeeService {
        public Task<List<Employee>> GetEmployeeesAsync() {
            throw new System.NotImplementedException();
        }

        public Task<Employee> GetEmployeeAsync(int id) {
            throw new System.NotImplementedException();
        }

        public Task<Employee> CreateEmployeeAsync(Employee employee) {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteEmployeeAsync(int id) {
            throw new System.NotImplementedException();
        }

        public Task<Employee> EditEmployeeAsync(Employee employee) {
            throw new System.NotImplementedException();
        }
    }
}