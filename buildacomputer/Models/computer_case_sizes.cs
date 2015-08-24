using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using buildacomputer.Models;

namespace buildacomputer.Models
{
    public class computer_case_sizes
    {
        public long computer_case_size_id { get; set; }

        public string computer_case_size_name { get; set; }

        public virtual ICollection<computer_cases> computer_cases { get; set; }
    }
}