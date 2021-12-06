using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Employee;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces {
    public interface IEmployeeService {
        Task<List<Employee>> GetEmployeesAsync();
        Task<Employee> GetEmployeeAsync(int id);
        Task<Employee> CreateEmployeeAsync(AddEmployee employee);
        Task<bool> DeleteEmployeeAsync(int id);
        Task<Employee> EditEmployeeAsync(EditEmployee employee);
    }
}