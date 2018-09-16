using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigurationManagerCore
{
    public class ConfigurationManager
    {
        private static IConfigurationRoot config;
        static ConfigurationManager()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("app.json");
            config = builder.Build();
        }

        public static IConfigurationRoot AppSettings
        {
            get
            {
                return config;
            }
        }

        public static string Get(string key)
        {
            return config[key];
        }

    }
}
