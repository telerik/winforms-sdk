using System;
using System.Linq;

using RadGridViewEFCodeFirst.Models;

namespace RadGridViewEFCodeFirst.Data.Contracts
{
    public interface IRadGridViewEFCodeFirstData
    {
        IGenericRepository<Order> Orders { get; }

        IGenericRepository<OrderType> OrderTypes { get; }

        IGenericRepository<Shipper> Shippers { get; }

        void SaveChanges();
    }
}
