using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace buildacomputer.Models
{
    public class memories
    {
        public int memory_id { get; set; }

        public string memory_name { get; set; }

        public int memory_speed_mhz { get; set; }

        public int memory_size_mb { get; set; }

        public int manufacturer_id { get; set; }

        public int memory_type_id { get; set; }

        public virtual memory_types memory_types { get; set; }
        public virtual manufacturers manufacturers { get; set; }
    }
}