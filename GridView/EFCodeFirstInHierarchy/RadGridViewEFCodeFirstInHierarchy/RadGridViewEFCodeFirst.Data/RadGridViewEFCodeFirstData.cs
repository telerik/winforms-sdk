using System;
using System.Collections.Generic;
using System.Linq;

using RadGridViewEFCodeFirst.Data.Contracts;
using RadGridViewEFCodeFirst.Models;

namespace RadGridViewEFCodeFirst.Data
{
    public class RadGridViewEFCodeFirstData : IRadGridViewEFCodeFirstData
    {
        private IRadGridViewEFCodeFirstContext context;
        private IDictionary<Type, object> repositories;

        public RadGridViewEFCodeFirstData()
            : this(new RadGridViewEFCodeFirstContext())
        {
        }

        public RadGridViewEFCodeFirstData(IRadGridViewEFCodeFirstContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IGenericRepository<Order> Orders
        {
            get
            {
                return this.GetRepository<Order>();
            }
        }

        public IGenericRepository<OrderType> OrderTypes
        {
            get
            {
                return this.GetRepository<OrderType>();
            }
        }

        public IGenericRepository<Shipper> Shippers
        {
            get
            {
                return this.GetRepository<Shipper>();
            }
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        private IGenericRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);
            if (!this.repositories.ContainsKey(typeOfModel))
            {
                Type type = typeof(RadGridViewEFCodeFirstRepository<T>);
                this.repositories.Add(typeOfModel, Activator.CreateInstance(type, this.context));
            }

            return (IGenericRepository<T>)this.repositories[typeOfModel];
        }
    }
}
