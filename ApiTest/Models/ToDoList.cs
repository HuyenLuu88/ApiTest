using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTest.Models
{
    public class ToDoList
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Owner { get; set; }
        public DateTime insertDate { get; set; }
        public DateTime lastUpdate { get; set; }
        public string Status { get; set; }
    }
}