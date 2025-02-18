using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HydraApi.Data;
namespace HydraApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<HydraContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("HydraContext") ?? throw new InvalidOperationException("Connection string 'HydraContext' not found.")));

            // Add services to the container.

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
