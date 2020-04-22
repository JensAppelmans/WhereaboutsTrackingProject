using System.Data.Entity.ModelConfiguration;
using Whereabouts.Core.Models;

namespace Whereabouts.DAL.EnityConfigurations
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {

            //1 First tables overrides
            //2 Second override PK
            //3 Add Property configurations => Alphabeticaly

            Property(c => c.Name).IsRequired().HasMaxLength(50);
            Property(c => c.Phonenumber).IsRequired().HasMaxLength(50);
            Property(c => c.Email).IsRequired().HasMaxLength(50);
            Property(c => c.Company).HasMaxLength(50);
            Property(c => c.Btw).HasMaxLength(50);

            HasMany(c => c.Adresses)
                .WithRequired(a => a.Customer);
            HasMany(c => c.Vehicles)
                .WithRequired(t => t.Customer); 
            
        }
    }
}
