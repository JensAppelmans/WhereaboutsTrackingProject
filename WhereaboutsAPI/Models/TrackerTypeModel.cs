using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whereabouts.API.Models
{
    public class TrackerTypeModel
    {
        public int TrackerModelId { get; set; }
        public string Name { get; set; }
        public ICollection<TrackerModel> Trackers { get; set; }
    }
}
