using System;
using System.Data.Entity;
using System.Linq;

using RadGridViewEFCodeFirst.Data.Contracts;
using RadGridViewEFCodeFirst.Data.Migrations;
using RadGridViewEFCodeFirst.Models;

namespace RadGridViewEFCodeFirst.Data
{
    public class RadGridViewEFCodeFirstContext : DbContext, IRadGridViewEFCodeFirstContext
    {
        public RadGridViewEFCodeFirstContext()
            : base("RadGridViewEFCodeFirstConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<RadGridViewEFCodeFirstContext, Configuration>());
        }

        public IDbSet<Order> Orders { get; set; }

        public IDbSet<OrderType> OrderTypes  { get; set; }

        public IDbSet<Shipper> Shippers { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}
