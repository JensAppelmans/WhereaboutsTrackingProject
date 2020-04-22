using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whereabouts.Core;
using Whereabouts.Core.Repositories;
using Whereabouts.DAL.Migrations;
using Whereabouts.DAL.Repositories;

namespace Whereabouts.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICustomerRepository Customers { get; }
        public IAdressRepository Adresses { get; }

        private readonly DatabaseContext _context;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
            Customers = new CustomerRepository(_context);
            Adresses = new AdressRepository(_context);
        }


        public int complete()
        {
            return _context.SaveChanges(); 
        }

        public void Dispose()
        {
            _context.Dispose(); 
        }
    }
}
