using ABS.Interfaces.Services;
using BLL.Services;
using FizzWare.NBuilder;
using GUI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RePo.MockRePo;
using System;
using System.Configuration;

namespace AllInOne
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new login());

            //var host = CreateHostBuilder().Build();
            //ServiceProvider = host.Services;

            //Application.Run(ServiceProvider.GetRequiredService<Form1>());


        }


        static IHostBuilder CreateHostBuilder()
        {

            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<ABS.Interfaces.Services.ICustomerService, BLL.Services.PrivatCustomerService>(); // Replace with actual implementation
                    services.AddTransient<ABS.Interfaces.RePo.ICustomerRePo, RePo.DBRePo.SqlRePo>();
                    services.AddTransient<ABS.Interfaces.Models.IAdressModel, RePo.ModelsRePo.Adress>();
                    services.AddTransient<ABS.Interfaces.Models.ICustomerModel, RePo.ModelsRePo.Customer>();
                    services.AddTransient<Form1>();

                });
        }
    }
}

