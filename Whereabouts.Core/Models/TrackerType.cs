using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whereabouts.Core.Models
{
    public class TrackerType
    {
        public int TrackerTypeId { get; set; }
        public string Name { get; set; }
        public ICollection<Tracker> Trackers { get; set; }
    }
}
