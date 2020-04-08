using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using AutoMapper;
using CaWorkshop.Application.TodoLists.Queries.GetTodoLists;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CaWorkshop.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
