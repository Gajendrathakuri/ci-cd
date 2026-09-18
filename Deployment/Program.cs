
using Deployment.Controllers;
using Microsoft.EntityFrameworkCore;

namespace Deployment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<Appdbcontext>(options =>
     options.UseSqlServer("Data Source=localhost;Database=Db;User Id=sa;Password=Thakuri1@;TrustServerCertificate=True;")
 ); 

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
