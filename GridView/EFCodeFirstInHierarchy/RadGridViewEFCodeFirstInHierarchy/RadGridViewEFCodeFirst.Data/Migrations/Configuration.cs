namespace RadGridViewEFCodeFirst.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RadGridViewEFCodeFirst.Data.RadGridViewEFCodeFirstContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "RadGridViewEFCodeFirst.Data.RadGridViewEFCodeFirstContext";
        }

        protected override void Seed(RadGridViewEFCodeFirst.Data.RadGridViewEFCodeFirstContext context)
        {
        }
    }
}
