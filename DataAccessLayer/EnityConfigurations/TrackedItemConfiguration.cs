using System.Data.Entity.ModelConfiguration;
using Whereabouts.Core.Models;

namespace Whereabouts.DAL.EnityConfigurations
{
    class TrackedItemConfiguration : EntityTypeConfiguration<TrackedItem>
    {
        public TrackedItemConfiguration()
        {
            Property(t => t.Name).IsRequired().HasMaxLength(50);
            Property(t => t.ChassisNumber).IsRequired().HasMaxLength(50);
            Property(t => t.LicensePlate).HasMaxLength(50);
            Property(t => t.Brand).HasMaxLength(50);

            HasMany(t => t.Trackers)
               .WithOptional(tr => tr.TrackedItem); 


        }
    }
}
