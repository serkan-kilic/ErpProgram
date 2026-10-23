using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Config
{
    static class AppConfig
    {
        public static string ConnectionString { get; }
        static AppConfig()
        {
           var configuration = new ConfigurationBuilder().SetBasePath(AppContext.BaseDirectory).AddJsonFile("appsettings.json").Build();

            ConnectionString = configuration.GetConnectionString("DefaultString");
        }
    }
}
