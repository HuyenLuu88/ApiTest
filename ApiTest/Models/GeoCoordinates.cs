using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTest.Models
{
    public class GeoCoordinates
    {
        public string BranchName { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Region { get; set; }
        public DateTime PlainShiftStart { get; set; }
        public DateTime PlainShiftEnd { get; set; }
    }
}