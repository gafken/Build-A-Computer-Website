using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace buildacomputer.Models
{
    public class l_computer_cases_cooling_fans
    {
        public int computer_case_id { get; set; }

        public int cooling_fan_size_id { get; set; }

        public int cooling_fan_size_count { get; set; }

        public virtual computer_cases computer_cases { get; set; }
        public virtual cooling_fan_sizes cooling_fan_sizes { get; set; }
    }
}