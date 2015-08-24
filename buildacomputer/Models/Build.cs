using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace buildacomputer.Models
{
    public class Build
    {
        public long buildID { get; set; }
        public long motherboard_id { get; set; }
        public long computer_case_id { get; set; }
        public long hard_drive_id { get; set; }
        public long? optical_drive_id { get; set; }
        public long power_supply_id { get; set; }
        public long processer_id { get; set; }
        public long? sound_card_id { get; set; }
        public long? video_adapter_id { get; set; }
        public string buildType { get; set; }
        public int iterator { get; set; }
        public DateTime BuildTime { get; set; }

        public virtual ICollection<UserBuilds> UserBuilds { get; set; }
        public virtual motherboards motherboards { get; set; }
        public virtual computer_cases computer_cases { get; set; }
        public virtual hard_drives hard_drives { get; set; }
        public virtual optical_drives optical_drives { get; set; }
        public virtual power_supplies power_supplies { get; set; }
        public virtual processors processors { get; set; }
        public virtual sound_cards sound_cards { get; set; }
        public virtual video_adapters video_adapters { get; set; }
    }
}