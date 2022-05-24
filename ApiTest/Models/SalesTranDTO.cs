using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTest.Models
{
    public class SalesTranDTO
    {
        public int totalSales { get; set; }
        public int gamesTotal { get; set; }
        public float birthday { get; set; }
        public int FnB { get; set; }
        public int Store { get; set; }
        public int Academy { get; set; }
        public int Trips { get; set; }
        public int Tournaments { get; set; }
        public int Others { get; set; }
        public DateTime SalesDate { get; set; }
    }
}