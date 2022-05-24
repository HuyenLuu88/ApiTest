using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTest.Models
{
    public class AttendanceLog
    { 
        public int EmpID { get; set; }
        public DateTime AttDate { get; set; }
        public DateTime InTime1 { get; set; }
        public DateTime OutTime1 { get; set; }
        public DateTime InTime2 { get; set; }
        public DateTime OutTime2 { get; set; }
    }
}