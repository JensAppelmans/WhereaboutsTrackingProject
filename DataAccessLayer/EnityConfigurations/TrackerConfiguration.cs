using System.Data.Entity.ModelConfiguration;
using Whereabouts.Core.Models;

namespace Whereabouts.DAL.EnityConfigurations
{
    public class TrackerConfiguration : EntityTypeConfiguration<Tracker>
    {
        public TrackerConfiguration()
        {
            Property(tr => tr.IMEI).IsRequired().HasMaxLength(50);



        }
    }
}
