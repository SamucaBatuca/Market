using System;
using System.Globalization;
using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore;
using Market.DBConection;
using Market.Objects;


namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Adiciona o DbContext usando PostgreSQL (mude UseNpgsql se for usar SQL Server ou SQLite)
            builder.Services.AddDbContext<Data>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            app.Run();
        }
    }
}