﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace buildacomputer.Models
{
    public class l_optical_drives_optical_disk_formats
    {
        [Key]
        public long optical_disk_format_id { get; set; }

        public long optical_drive_id { get; set; }

        public long optical_disk_format_write_speed { get; set; }

        public virtual optical_disk_formats optical_disk_formats { get; set; }
        public virtual optical_drives optical_drives { get; set; }
    }
}