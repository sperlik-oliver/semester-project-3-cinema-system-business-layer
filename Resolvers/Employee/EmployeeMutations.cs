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

        public async Task<Models.Employee> CreateEmployee(AddEmployee input) {

            try {
                return await employeeService.CreateEmployeeAsync(input);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Models.Employee> EditEmployee(EditEmployee input) {
            try {
                return await employeeService.EditEmployeeAsync(input);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<bool> DeleteEmployee(int id) {
            try {
                return await employeeService.DeleteEmployeeAsync(id);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}