﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using buildacomputer.Models;

namespace buildacomputer.Models
{
    public class cooling_fan_sizes
    {
        public int cooling_fan_size_id { get; set; }

        public int cooling_fan_size_diameter_mm { get; set; }

        public virtual ICollection<l_computer_cases_cooling_fans> l_computer_cases_cooling_fans { get; set; }
        public virtual ICollection<power_supplies> power_supplies { get;  set; }
    }
}