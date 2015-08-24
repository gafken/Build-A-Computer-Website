using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace buildacomputer.Models
{
    public class UserBuilds
    {
        public string userID { get; set; }
        public int buildID {get;set;}

        public virtual Build Build { get; set; }
        public virtual User User {get; set;}
    }
}