
using Microsoft.EntityFrameworkCore;
using Zaj10.Entities;

namespace Zaj10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddDbContext<UniversityDbContext>(opt =>
            {
                string connString = builder.Configuration.GetConnectionString("DbConnString");
                opt.UseSqlServer(connString);
            });

            //Add-Migration StudentAndGroupTables
            //Update-Database
            //Remove-Migration

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}