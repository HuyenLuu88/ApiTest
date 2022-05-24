using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTest.Models
{
    public class Log
    {
        public string name { get; set; }
        public string mobile { get; set; }
        public DateTime checkIn { get; set; }
        public DateTime checkOut { get; set; }
        public string Schedule { get; set; }
        public string branch { get; set; }
    }
}