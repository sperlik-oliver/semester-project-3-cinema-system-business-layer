using System;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using HotChocolate.Types;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Employee {
    [ExtendObjectType(Name = "Mutation")]
    public class EmployeeMutations {
        private IEmployeeService employeeService;

        public EmployeeMutations() {
            employeeService = new EmployeeService();
        }

        public async Task<Models.Employee> CreateEmployee(AddEmployee employee) {

            try {
                return await employeeService.CreateEmployeeAsync(employee);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Models.Employee> EditEmployee(EditEmployee employee) {
            try {
                return await employeeService.EditEmployeeAsync(employee);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<bool> DeleteEmployee(int employeeId) {
            try {
                return await employeeService.DeleteEmployeeAsync(employeeId);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}