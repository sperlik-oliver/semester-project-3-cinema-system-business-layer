using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Ticket;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Utilities;
using Newtonsoft.Json;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes {
    public class TicketService : ITicketService {
        private readonly string uri = "https://abdot-api.herokuapp.com/api/ticket";
        
        public async Task<List<Ticket>> GetTicketsAsync()
        {
            using var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync($"{uri}s");
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
            var result = await responseMessage.Content.ReadAsStringAsync();
            var tickets = JsonConvert.DeserializeObject<List<Ticket>>(result);
            return tickets;
        }

        public async Task<Ticket> GetTicketAsync(int id) {
            using var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync($"{uri}/{id}");
            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            var ticket = JsonConvert.DeserializeObject<Ticket>(result);
            return ticket;
        }

        public async Task<Ticket> CreateTicketAsync(AddTicket ticket) {
            using var httpClient = new HttpClient();

            var content = new StringContent(
                CustomJsonConvert.SerializeObject(ticket),
                Encoding.UTF8,
                "application/json"
            );
            var responseMessage = await httpClient.PostAsync($"{uri}/create", content);

            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();

            var createdTicket = JsonConvert.DeserializeObject<Ticket>(result);
            return createdTicket;
        }

        public async Task<bool> DeleteTicketAsync(long id) {
            using var httpClient = new HttpClient();

            var responseMessage = await httpClient.DeleteAsync($"{uri}/delete/{id}");

            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            return true;
        }

        public async Task<Ticket> EditTicketAsync(EditTicket ticket) {
            using var httpClient = new HttpClient();

            var content = new StringContent(
                CustomJsonConvert.SerializeObject(ticket),
                Encoding.UTF8,
                "application/json"
            );
            var responseMessage = await httpClient.PutAsync($"{uri}/edit/{ticket.Id}", content);

            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            var editedTicket = JsonConvert.DeserializeObject<Ticket>(result);
            return editedTicket;
        }
    }
}