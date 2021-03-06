using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using HotChocolate.Types;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Employee {

    [ExtendObjectType(Name = "Query")]
    public class EmployeeQueries {
        private IEmployeeService employeeService;

        public EmployeeQueries() {
            try {
                employeeService = new EmployeeService();
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }


        public async Task<List<Models.Employee>> GetEmployees() {
            try {
                return await employeeService.GetEmployeesAsync();
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Models.Employee> GetEmployee(int id) {
            try {
                return await employeeService.GetEmployeeAsync(id);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}