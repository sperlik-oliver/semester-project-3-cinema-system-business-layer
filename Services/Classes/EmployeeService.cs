using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Employee;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Utilities;
using Newtonsoft.Json;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes {
    public class EmployeeService : IEmployeeService {
        private readonly string uri = "https://abdot-api.herokuapp.com/api/employee";

        public async Task<List<Employee>> GetEmployeesAsync() {
            using HttpClient httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync($"{uri}s");
            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            var employees = JsonConvert.DeserializeObject<List<Employee>>(result);
            return employees;
        }

        public async Task<Employee> GetEmployeeAsync(int id) {
            using HttpClient httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync($"{uri}/{id}");
            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            var employee = JsonConvert.DeserializeObject<Employee>(result);
            return employee;
        }

        public async Task<Employee> CreateEmployeeAsync(AddEmployee employee) {
            using HttpClient httpClient = new HttpClient();
            var content = new StringContent(
                CustomJsonConvert.SerializeObject(employee),
                Encoding.UTF8,
                "application/json"
            );
            Console.WriteLine(CustomJsonConvert.SerializeObject(employee));
            var responseMessage = await httpClient.PostAsync($"{uri}/create", content);

            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(result);
            var createdEmployee = JsonConvert.DeserializeObject<Employee>(result);
            return createdEmployee;
        }

        public async Task<bool> DeleteEmployeeAsync(int id) {
            using HttpClient httpClient = new HttpClient();

            var responseMessage = await httpClient.DeleteAsync($"{uri}/delete/{id}");
            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            return true;
        }

        public async Task<Employee> EditEmployeeAsync(EditEmployee employee) {
            using HttpClient httpClient = new HttpClient();

            var content = new StringContent(
                CustomJsonConvert.SerializeObject(employee),
                Encoding.UTF8,
                "application/json"
            );
            var responseMessage = await httpClient.PutAsync($"{uri}/edit/{employee.Id}", content);

            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();

            var editedEmployee = JsonConvert.DeserializeObject<Employee>(result);
            return editedEmployee;
        }
    }
}