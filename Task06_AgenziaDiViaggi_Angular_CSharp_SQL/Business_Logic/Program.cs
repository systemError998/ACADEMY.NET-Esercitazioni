
using Business_Logic.Context;
using Business_Logic.Models;
using Business_Logic.Repos;
using Business_Logic.Services;
using Microsoft.EntityFrameworkCore;

namespace Business_Logic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins, policy =>
                {
                    policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<LaPerlaNeraContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseTest"))
                );

            // Add services to the container.

            builder.Services.AddScoped<Destinazione>();
            builder.Services.AddScoped<DestinazioneRepo>();
            builder.Services.AddScoped<DestinazioneService>();

            builder.Services.AddScoped<PacchettoVacanza>();
            builder.Services.AddScoped<PacchettoVacanzaRepo>();
            builder.Services.AddScoped<PacchettoVacanzaService>();

            builder.Services.AddScoped<Recensione>();
            builder.Services.AddScoped<RecensioneRepo>();
            builder.Services.AddScoped<RecensioneService>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
