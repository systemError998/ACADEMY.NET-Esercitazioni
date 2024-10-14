
using Microsoft.EntityFrameworkCore;
using Task05_Gestionale_Officina.Context;
using Task05_Gestionale_Officina.Repositories;
using Task05_Gestionale_Officina.Services;

namespace Task05_Gestionale_Officina
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

            #region BUILDER PER CONNESSIONE DATABASE

            //creo il context
            builder.Services.AddDbContext<OfficinaContext>(
                options => options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DatabaseTest")
                )
            );

            //creo le repo
            builder.Services.AddSingleton<ClienteRepo>();
            builder.Services.AddSingleton<VeicoloRepo>();

            builder.Services.AddScoped<ClienteService>();
            builder.Services.AddScoped<VeicoloService>();

            #endregion

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
