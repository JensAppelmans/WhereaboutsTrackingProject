using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whereabouts.Core.Models;
using Whereabouts.Core.Repositories;
using Whereabouts.DAL.Migrations;

namespace Whereabouts.DAL.Repositories
{
    public class AdressRepository : Repository<Adress>, IAdressRepository
    {
        private readonly DatabaseContext _context;

        public AdressRepository(DatabaseContext context) : base(context)
        {
            _context = context;
        }
    }
}
