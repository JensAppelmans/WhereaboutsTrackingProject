using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whereabouts.API.Models
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Btw { get; set; }
        //public ICollection<AdressModel> Adresses { get; set; }
        //public ICollection<TrackedItemModel> Vehicles { get; set; }
    }
}
