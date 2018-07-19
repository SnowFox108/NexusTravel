using System;
using System.IO;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NexusTravel.Dal;
using NexusTravel.Dal.Queries;
using NexusTravel.Main.StaticDataCache;
using NLog.Extensions.Logging;

namespace NexusTravel.ClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");


            var configuration = builder.Build();
            var serviceProvider = BuildDi(configuration);

            serviceProvider.GetRequiredService<Runner>();

            Console.WriteLine("Press ANY key to exit");
            Console.ReadLine();
        }

        private static IServiceProvider BuildDi(IConfigurationRoot root)
        {
            var services = new ServiceCollection();

            services.AddTransient(r => root);
            services.AddTransient<Runner>();

            services.AddSingleton<ILoggerFactory, LoggerFactory>();
            services.AddSingleton(typeof(ILogger<>), typeof(Logger<>));
            services.AddLogging((builder) => builder.SetMinimumLevel(LogLevel.Trace));

            services.AddTransient<IStaticDataService, StaticDataService>();
            services.AddTransient<IStaticDataCachingService, StaticDataCachingService>();

            services.AddTransient<IConfigConnection, ConfigConnection>();
            services.AddTransient<IConnectionFactory, ConnectionFactory>();

            services.AddTransient<ISystemSettingQuery, SystemSettingQuery>();

            services.AddTransient<TestSystemSettings>();
            services.AddAutoMapper();

            var serviceProvider = services
                .AddMemoryCache()
                .BuildServiceProvider();


            var loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();

            loggerFactory.AddNLog(new NLogProviderOptions
            {
                CaptureMessageTemplates = true,
                CaptureMessageProperties = false
            });
            loggerFactory.ConfigureNLog("NLog.config");

            return serviceProvider;
        }

    }
}
