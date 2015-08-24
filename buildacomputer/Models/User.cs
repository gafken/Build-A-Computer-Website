using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace buildacomputer.Models
{
    public class User
    {
        public string userID {get; set;}
        public string firstName {get; set;}
        public string lastName {get; set;}
        public string question {get; set;}
        public string answer {get;set;}
        public string title { get; set; }
    }
}