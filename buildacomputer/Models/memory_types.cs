﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using buildacomputer.Models;

namespace buildacomputer.Models
{
    public class memory_types
    {
        public int memory_type_id { get; set; }

        public string memory_type_name { get; set; }

        public virtual ICollection<motherboards> motherboards { get; set; }
        public virtual ICollection<memories> memories { get; set; }
        public virtual ICollection<video_adapters> video_adapters { get; set; }
    }
}