﻿using Microsoft.Extensions.Configuration;

namespace UserSecrets
{
    public class DatabaseConnection<T>
        where T : class
    {
        public static string GetSecret(string secretName)
        {
            var secretConfig = new ConfiguratiocnBuilder()
                .AddUserSecrets<T>()
                .Build();
            return secretConfig[secretName];
        }
    }
}