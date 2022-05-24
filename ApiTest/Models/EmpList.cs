using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTest.Models
{
    public class EmpList
    {
        public string EmpID { get; set; }
        public string EmpName { get; set; }
        public string Password { get; set; }
        public string EmpLevel { get; set; }
        public string Department { get; set; }
        public string Status { get; set; }
        public string isLogin { get; set; }
    }
}