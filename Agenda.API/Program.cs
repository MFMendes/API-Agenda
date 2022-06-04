using Libraries.Core.Api.Hosting;
using Libraries.Core.Api.Logs;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.IO;


namespace Agenda.API
{
    public class Program
    {
        public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json",
                optional: true)
            .AddEnvironmentVariables()
            .Build();

        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(Configuration)
                .CreateLogger();

            try
            {
                Log.Information("Iniciando aplica��o...");

                BuildWebHost(args).Run();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Host encerrado de maneira inesperada!");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            string portaBind = Configuration.GetSection("Aplicacao:Porta").Value;
            var builder = WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseConfiguration(Configuration)
                .UseUrls(portaBind)
                .UseSerilog((provider, context, loggerConfiguration) =>
                {
                    loggerConfiguration
                        .ReadFrom.Configuration(Configuration).Enrich.WithAspnetcoreHttpcontext(provider);
                });

            return builder.Build();
        }
    }
}