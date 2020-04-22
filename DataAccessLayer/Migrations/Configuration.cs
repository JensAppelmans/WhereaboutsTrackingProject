namespace Whereabouts.DAL.Migrations
{
    using System;
    using System.Collections.ObjectModel;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Whereabouts.Core.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Whereabouts.DAL.Migrations.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Whereabouts.DAL.Migrations.DatabaseContext context)
        {
            context.Vehicles.AddOrUpdate(v => v.VehicleId,
                   new Vehicle() { VehicleId = 1, Name = "Auto" },
                   new Vehicle() { VehicleId = 2, Name = "Bestelwagen" },
                   new Vehicle() { VehicleId = 3, Name = "Vrachtwagen" }
                   );

            context.TrackerTypes.AddOrUpdate(tm => tm.TrackerTypeId,
                 new TrackerType() { TrackerTypeId = 1, Name = "AVL" },
                 new TrackerType() { TrackerTypeId = 2, Name = "FMB920" },
                 new TrackerType() { TrackerTypeId = 3, Name = "FMA240" },
                 new TrackerType() { TrackerTypeId = 4, Name = "GEOSPOTTER" }
                 );

            context.Customers.AddOrUpdate(c => c.CustomerId,
                new Customer()
                {
                    CustomerId = "b82ba79f - 7431 - 4ff2 - af80 - be8e062c1e4f",
                    Name = "Jens Appelmans",
                    Phonenumber = "0478093406",
                    Email = "jens.appelmans@gmail.com",
                    Company = "Geotracer",
                    Adresses = new Collection<Adress>() { new Adress() { AdressId = 1, Country = "België", City = "Ninove", Street = "Kerkplein 34", Zipcode = "9400" } },
                    Vehicles = new Collection<TrackedItem>() { new TrackedItem() { TrackedItemId = 1, Brand = "Toyota", LicensePlate = "1-NPU-264", ChassisNumber = "ANCKDO54545445DQ", Name = "Toyota 1-NPU-264", VehicleId = 1 ,
                        Trackers = new Collection<Tracker>() { new Tracker() { TrackerId = 1, IMEI = "984512657812" , ModelId = 2  } } } }
                },
                new Customer()
                {
                    CustomerId = "ca0a20c7 - 11ee - 4d3e-a36b - 37f9023dab9a",
                    Name = "Préscillia Haegeman",
                    Phonenumber = "0412784585",
                    Email = "Precillia.haegeman@gmail.com",
                    Adresses = new Collection<Adress>() { new Adress() { AdressId = 1, Country = "België", City = "Ninove", Street = "Okegemdorp 54", Zipcode = "9400" } },
                    Vehicles = new Collection<TrackedItem>() { new TrackedItem() { TrackedItemId = 2, Brand = "Nissan", LicensePlate = "1-BLA-007", ChassisNumber = "NGFBAG047825SQ45", Name = "Nissan 1-BLA-007", VehicleId = 1 ,
                        Trackers = new Collection<Tracker>() { new Tracker() { TrackerId = 2, IMEI = "451298786532" , ModelId = 1  } } } }
                },
                new Customer()
                {
                    CustomerId = "383baa53 - 36df - 46a3 - b3f5 - 456efb500718",
                    Name = "Sven Paeleman",
                    Phonenumber = "+3245781254",
                    Email = "sven@geotracer.be",
                    Company = "Geotracer",
                    Adresses = new Collection<Adress>() { new Adress() { AdressId = 3, Country = "België", City = "Drongen", Street = "Gaverlandstraat 73", Zipcode = "9031" } },
                    Vehicles = new Collection<TrackedItem>() { new TrackedItem() { TrackedItemId = 3, Brand = "Mercedes", LicensePlate = "1-BLS-787", ChassisNumber = "VGFDBH054879QS", Name = "Mercedes 1-BLS-787", VehicleId = 2 ,
                        Trackers = new Collection<Tracker>() { new Tracker() { TrackerId = 1, IMEI = "984512657812" , ModelId = 3  } } } }
                }
                );
        }
    }
}
