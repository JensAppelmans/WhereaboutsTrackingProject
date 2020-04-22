using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whereabouts.Core.Models;
using Whereabouts.Core.Repositories;
using Whereabouts.DAL.Migrations;

namespace Whereabouts.DAL.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly DatabaseContext _context;

        public CustomerRepository(DatabaseContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetCustomersFulldetails()
        {
            return _context.Customers.Include(c => c.Adresses).ToList(); 
        }

      
    }
}
