using System.Data.Entity.ModelConfiguration;
using Whereabouts.Core.Models;

namespace Whereabouts.DAL.EnityConfigurations
{
    public class VehicleConfiguration : EntityTypeConfiguration<Vehicle>
    {
        public VehicleConfiguration()
        {
            Property(v => v.Name).IsRequired().HasMaxLength(50);
            Property(v => v.picturePath).HasMaxLength(200);

            HasMany(v => v.Vehicles)
                .WithRequired(t => t.Vehicle)
                .HasForeignKey(t => t.VehicleId);
        }
    }
}
