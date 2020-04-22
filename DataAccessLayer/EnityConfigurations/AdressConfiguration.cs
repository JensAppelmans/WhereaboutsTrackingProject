using System.Data.Entity.ModelConfiguration;
using Whereabouts.Core.Models;

namespace Whereabouts.DAL.EnityConfigurations
{
    public class AdressConfiguration : EntityTypeConfiguration<Adress>
    {
        public AdressConfiguration()
        {
            Property(a => a.Street).IsRequired().HasMaxLength(50);
            Property(a => a.City).IsRequired().HasMaxLength(50);
            Property(a => a.Country).IsRequired().HasMaxLength(50);
            Property(a => a.Zipcode).IsRequired().HasMaxLength(10);
             
        }
    }
}
