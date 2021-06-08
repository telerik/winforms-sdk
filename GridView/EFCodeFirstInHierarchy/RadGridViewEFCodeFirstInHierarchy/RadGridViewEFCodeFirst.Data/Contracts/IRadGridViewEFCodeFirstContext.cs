using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

using RadGridViewEFCodeFirst.Models;

namespace RadGridViewEFCodeFirst.Data.Contracts
{
    public interface IRadGridViewEFCodeFirstContext
    {
        IDbSet<Order> Orders { get; set; }

        IDbSet<OrderType> OrderTypes { get; set; }

        IDbSet<Shipper> Shippers { get; set; }

        IDbSet<T> Set<T>() where T : class;

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        void SaveChanges();
    }
}
