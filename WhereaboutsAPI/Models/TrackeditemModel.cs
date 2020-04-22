using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whereabouts.API.Models
{
    public class TrackedItemModel
    {
        public int TrackedItemId { get; set; }
        public string Name { get; set; }
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string ChassisNumber { get; set; }

        //public Customer Customer { get; set; }
        //public Vehicle Vehicle { get; set; }
        public int VehicleId { get; set; }

        public ICollection<TrackerModel> Trackers { get; set; }
    }
}
