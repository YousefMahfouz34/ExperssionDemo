
using ExperssionTreeInRunTimeDemo.Context;
using ExperssionTreeInRunTimeDemo.Services;
using Microsoft.EntityFrameworkCore;

namespace ExperssionTreeInRunTimeDemo
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
            builder.Services.AddDbContext<DemoContext>(option=>option.UseSqlServer(builder.Configuration.GetConnectionString("CS")));
              
            builder.Services.AddScoped<IEmpolyeeServices,EmpolyeeServices>();
            builder.Services.AddScoped<IDepartmentServices, DepartmentServices>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
