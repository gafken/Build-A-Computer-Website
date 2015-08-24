using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using buildacomputer.Models;

namespace buildacomputer.Models
{
    public class hard_drive_features
    {
        public long hard_drive_feature_id { get; set; }

        public string hard_drive_feature_name { get; set; }

        public virtual ICollection<l_hard_drives_hard_drive_features> l_hard_drives_hard_drive_features { get; set; }
    }
}