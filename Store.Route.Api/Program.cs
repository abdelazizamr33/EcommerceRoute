
using Domain.Contracts;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Data;
using Services;
using ServicesAbstractions;
using Shared.errorModels;
using Store.Route.Api.Extensions;
using Store.Route.Api.Middlewares;
using AssemblyRefMapping=Services.AssemblyReference;

namespace Store.Route.Api
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.RegisterAllServices(builder.Configuration);

            var app = builder.Build();

            // after build configure any middleware

            await app.ConfigureMiddleWares();
            
            app.Run();
        }
    }
}
