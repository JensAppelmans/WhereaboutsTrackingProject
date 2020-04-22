using Whereabouts.DAL.EnityConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whereabouts.Core.Models;
using System.Data.Entity.SqlServer;

namespace Whereabouts.DAL.Migrations

{
    public class DatabaseContext : DbContext
    {
        internal static class MissingDllHack
        {

            private static SqlProviderServices instance = SqlProviderServices.Instance;
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<TrackedItem> TrackedItems { get; set; }
        public DbSet<Tracker> Trackers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<TrackerType> TrackerTypes { get; set; }

        public DatabaseContext() : base("Appelfleet")
        {
            this.Configuration.LazyLoadingEnabled = false;
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext, EF6Console.Migrations.Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerConfiguration()).Add(new AdressConfiguration()).Add(new TrackedItemConfiguration())
                .Add(new TrackerConfiguration()).Add(new VehicleConfiguration()).Add(new TrackerTypeConfiguration());

            base.OnModelCreating(modelBuilder);

        }

        
    }
}
