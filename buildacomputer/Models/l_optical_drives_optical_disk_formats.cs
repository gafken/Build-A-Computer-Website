﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace buildacomputer.Models
{
    public class l_optical_drives_optical_disk_formats
    {
        public int optical_disk_format_id { get; set; }

        public int optical_drive_id { get; set; }

        public int optical_disk_format_write_speed { get; set; }

        public virtual optical_disk_formats optical_disk_formats { get; set; }
        public virtual optical_drives optical_drives { get; set; }
    }
}