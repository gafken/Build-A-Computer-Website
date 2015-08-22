﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using buildacomputer.Models;

namespace buildacomputer.Models
{
    public class motherboard_form_factors
    {
        public int motherboard_form_factor_id { get; set; }

        public string motherboard_form_factor_name { get; set; }

        public virtual ICollection<motherboards> motherboards { get; set; }
        public virtual ICollection<power_supplies> power_supplies { get; set; }
        public virtual ICollection<computer_cases> computer_cases { get; set; }
    }
}