
using Microsoft.EntityFrameworkCore;
using Atv1Astrologia.Model;

namespace Atv1Astrologia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Initializes the HoroscopeManager instance
            HoroscopeManager.Instance.Initialize();

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddDbContext<ZodiacProfileContext>(opt =>
            opt.UseInMemoryDatabase("ZodiacBD"));

            builder.Services.AddSwaggerGen();

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