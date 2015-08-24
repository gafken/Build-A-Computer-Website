using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace buildacomputer.Models
{
    public class l_motherboard_peripheral_interfaces
    {
        public int motherboard_id { get; set; }

        public int peripheral_interface_id { get; set; }

        public int peripheral_interface_count { get; set; }

        public virtual motherboards motherboards { get; set; }
        public virtual peripheral_interfaces peripheral_interfaces { get; set; }
    }
}