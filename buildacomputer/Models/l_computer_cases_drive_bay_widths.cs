﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace buildacomputer.Models
{
    public class l_computer_cases_drive_bay_widths
    {
        public long computer_case_id { get; set; }

        public long drive_bay_width_id { get; set; }

        public long drive_bay_width_count { get; set; }

        public virtual computer_cases computer_cases { get; set; }
        public virtual drive_bay_widths drive_bay_widths { get; set; }
    }
}