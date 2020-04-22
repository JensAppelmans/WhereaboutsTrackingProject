using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whereabouts.API.Models
{
    public class VehicleModel
    {
        //public int VehicleId { get; set; }
        public string Name { get; set; }
        public string picturePath { get; set; }
        public ICollection<TrackedItemModel> Vehicles { get; set; }
    }
}
