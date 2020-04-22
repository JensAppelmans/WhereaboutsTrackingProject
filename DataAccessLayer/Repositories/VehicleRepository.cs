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
    public class VehicleRepository : Repository<Vehicle>, IVehicleRepository
    {
        private readonly DatabaseContext _context;

        public VehicleRepository(DatabaseContext context) : base(context)
        {
            _context = context;
        }
    }
}
