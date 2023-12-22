using ERP.Repository.Service;
using System;
using System.Configuration;
using System.Data.Services.Client;

namespace ERP.Repository
{
    public static class ConnectionManager
    {
        private static AWEntities context;

        public static AWEntities Context
        {
            get
            {
                return context;
            }
        }

        static ConnectionManager()
        {
            var serviceUrl = GetServiceUrl();
            context = new AWEntities(new Uri(serviceUrl));
            
            context.MergeOption =  MergeOption.PreserveChanges;
            context.SaveChangesDefaultOptions = SaveChangesOptions.ContinueOnError;
            context.IgnoreMissingProperties = true;
        }

        private static string GetServiceUrl()
        {
            Configuration configurationManager = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationCollection appSettings = configurationManager.AppSettings.Settings;
            var serviceUrl = appSettings["serviceURL"].Value;
            return serviceUrl;
        }
    }
}