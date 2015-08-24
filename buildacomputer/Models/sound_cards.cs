using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace buildacomputer.Models
{
    public class sound_cards
    {
        public int sound_card_id { get; set; }

        public string sound_card_name { get; set; }

        public int manufacturer_id { get; set; }

        public int expansion_slot_id { get; set; }

        public int sound_chip_id { get; set; }

        public virtual manufacturers manufacturers { get; set; }
        public virtual expansion_slots expansion_slots { get; set; }
        public virtual sound_chips sound_chips { get; set; }
    }
}