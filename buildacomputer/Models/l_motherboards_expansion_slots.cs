using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace buildacomputer.Models
{
    public class l_motherboards_expansion_slots
    {
        public long motherboard_id { get; set; }

        public long expansion_slot_id { get; set; }

        public long expansion_slot_count { get; set; }

        public virtual motherboards motherboards { get; set; }
        public virtual expansion_slots expansion_slots { get; set; }
    }
}