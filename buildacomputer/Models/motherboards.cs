using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace buildacomputer.Models
{
    public class motherboards
    {
        public int motherboard_id { get; set; }

        public string motherboard_name { get; set; }

        public int front_usb_header_count { get; set; }

        public int manufacturer_id { get; set; }

        public int motherboard_nb_chipset_id { get; set; }

        public int motherboard_sb_chipset_id { get; set; }

        public int processor_socket_id { get; set; }

        public int memory_type_id { get; set; }

        public int motherboard_form_factor_id { get; set; }

        public int? gpu_id { get; set; } //nullable foreign key

        public int power_supply_standard_id { get; set; }

        public int lan_chip_id { get; set; }

        public int sound_chip_id { get; set; }

        public virtual manufacturers manufacturers { get; set; }
        public virtual motherboard_nb_chipsets motherboard_nb_chipsets { get; set; }
        public virtual motherboard_sb_chipsets motherboard_sb_chipsets { get; set; }
        public virtual processor_sockets processor_sockets { get; set; }
        public virtual memory_types memory_tyes { get; set; }
        public virtual motherboard_form_factors motherboard_form_factors { get; set; }
        public virtual gpus gpus { get; set; }
        public virtual power_supply_standards power_suply_sandards { get; set; }
        public virtual lan_chips lan_chips { get; set; }
        public virtual sound_chips sound_chips { get; set; }
    }
}