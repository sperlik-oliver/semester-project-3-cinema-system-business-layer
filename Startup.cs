using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Branches;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Employee;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Hall;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Movie;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Play;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Ticket;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api {
    public class Startup {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {
            services
                .AddGraphQLServer()
                //Queries
                .AddQueryType(q => q.Name("Query"))
                .AddTypeExtension<BranchQueries>()
                .AddTypeExtension<PlayQueries>()
                .AddTypeExtension<TicketQueries>()
                .AddTypeExtension<EmployeeQueries>()
                .AddTypeExtension<HallQueries>()
                .AddTypeExtension<MovieQueries>()

                //Mutation
                .AddMutationType(m => m.Name("Mutation"))
                .AddTypeExtension<BranchMutations>()
                .AddTypeExtension<PlayMutations>()
                .AddTypeExtension<TicketMutations>()
                .AddTypeExtension<EmployeeMutations>()
                .AddTypeExtension<HallMutations>()
                .AddTypeExtension<MovieMutations>()
                ;
            //Mutation
            services.AddScoped<IBranchService, BranchService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IHallService, HallService>();
            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<IPlayService, PlayService>();
            services.AddScoped<ITicketService, TicketService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseEndpoints(endpoints => { endpoints.MapGraphQL(); });
        }
    }
}