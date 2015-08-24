using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace buildacomputer.Models
{
    public class l_hard_drives_hard_drive_features
    {
        public int hard_drive_id { get; set; }

        public int hard_drive_feature_id { get; set; }

        public virtual hard_drives hard_drives { get; set; }
        public virtual hard_drive_features hard_drive_features { get; set; }
    }
}