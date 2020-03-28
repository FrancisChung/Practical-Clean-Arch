using System;
using System.Collections.Generic;
using System.Text;
using CaWorkshop.Application.TodoLists.Queries.GetTodoLists;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CaWorkshop.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IGetTodoListsQuery, GetTodoListsQuery>();
            return services;
        }
    }
}
