using ERP.Repository.Service;
using System;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ERP.Repository
{
    public abstract class RepositoryBase
    {
        private static readonly string propertyPrefix = "d";
        private static readonly string metadataPrefix = "m";
        private static readonly string propertiesXNamePrefix = "properties";

        public static AWEntities Context
        {
            get
            {
                return ConnectionManager.Context;
            }
        }

        static RepositoryBase()
        {
            Context.WritingEntity += OnContextWritingEntity;
        }

        protected static async void ExecuteQueryAsync<T>(DataServiceQuery<T> query, Action<IEnumerable<T>> callback)
        {
            var result = await Task<IEnumerable<T>>.Factory.FromAsync(query.BeginExecute, query.EndExecute, null);

            if (callback != null)
            {
                callback(result.ToList<T>());
            }
        }

        protected static async void ExecuteQueryAsync<T>(Task<IEnumerable<T>> task, Action<IEnumerable<T>> callback)
        {
            var result = await task;
            callback(result);
        }

        protected static async void ExecuteQueryAsync<T>(Task<T> task, Action<T> callback)
        {
            var result = await task;
            callback(result);
        }

        public static void Update(object entity)
        {
            Context.UpdateObject(entity);
        }

        public static void DeleteAndSave(object entity)
        {
            Context.DeleteObject(entity);
            SaveChanges();
        }

        public async static void SaveChangesAsync()
        {
            await Task.Run(() => SaveChanges());
        }

        public static void UpdateAndSaveAsync(object entity)
        {
            Update(entity);
            SaveChangesAsync();
        }

        public static void SaveChanges(Action callback = null)
        {
            try
            {
                var result = Context.SaveChanges();
                Debug.WriteLine(result);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("Error occurred while saving changes: {0}", ex.Message));
            }
            finally
            {
                if (callback != null)
                {
                    callback();
                }
            }
        }

        private static void OnContextWritingEntity(object sender, ReadingWritingEntityEventArgs e)
        {
            XName xNameEntityProperties = XName.Get(propertiesXNamePrefix, e.Data.GetNamespaceOfPrefix(metadataPrefix).NamespaceName);
            XElement xElementPayload = null;
            foreach (PropertyInfo property in e.Entity.GetType().GetProperties())
            {
                object[] notSerializableAttributes = property.GetCustomAttributes(typeof(EntityNotSerializableAttribute), false);
                if (notSerializableAttributes.Length > 0)
                {
                    if (xElementPayload == null)
                    {
                        xElementPayload = e.Data.Descendants().Where<XElement>(xe => xe.Name == xNameEntityProperties).First<XElement>();
                    }

                    XName xNameProperty = XName.Get(property.Name, e.Data.GetNamespaceOfPrefix(propertyPrefix).NamespaceName);
                    foreach (XElement xElementRemoveThisProperty in xElementPayload.Descendants(xNameProperty).ToList())
                    {
                        xElementRemoveThisProperty.Remove();
                    }
                }
            }
        }
    }
}
