﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace buildacomputer.Models
{
    public class l_motherboard_bus_interfaces
    {
        public long motherboard_id { get; set; }

        public long bus_interface_id { get; set; }

        public long bus_inteface_count { get; set; }

        public virtual motherboards motherboards { get; set; }
        public virtual bus_interfaces bus_interfaces { get; set; }
    }
}