using System.Data.Entity.ModelConfiguration;
using Whereabouts.Core.Models;

namespace Whereabouts.DAL.EnityConfigurations
{
    public class TrackerTypeConfiguration : EntityTypeConfiguration<TrackerType>
    {
        public TrackerTypeConfiguration()
        {
            Property(tr => tr.Name).IsRequired().HasMaxLength(50);

            HasMany(tm => tm.Trackers)
                .WithRequired(tr => tr.Model)
                .HasForeignKey(tr => tr.ModelId);

        }

    }
}
