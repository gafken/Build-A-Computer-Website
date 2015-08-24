using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace buildacomputer.Models
{
    public class l_optical_drives_optical_drive_features
    {
        public long optical_drive_id { get; set; }

        public long optical_drive_feature_id { get; set; }

        public virtual optical_drive_features optical_drive_features { get; set; }
        public virtual optical_drives optical_drives { get; set; }
    }
}