﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whereabouts.Core.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Btw { get; set; }
        public ICollection<Adress> Adresses { get; set; }
        public ICollection<TrackedItem> Vehicles { get; set; }
    }
}
