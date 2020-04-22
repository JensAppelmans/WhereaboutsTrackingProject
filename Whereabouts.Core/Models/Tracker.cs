using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whereabouts.Core.Models
{
    public class Tracker
    {
        public int TrackerId { get; set; }
        public string IMEI { get; set; }
        public TrackedItem TrackedItem { get; set; }
        public TrackerType Model { get; set; }
        public int ModelId { get; set; }
    }
}
