using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTest.Models
{
    public class SalesTran
    {
        public Int64 TransRef { get; set; }
        public DateTime SalesDate { get; set; }
        public string Branch { get; set; }
        public float TotalSalesAmount { get; set; }
        public float CashReceived { get; set; }
        public float CreditCard { get; set; }
        public float TaxVAT { get; set; }
        public float PartyDeposit { get; set; }
        public float DepositComments { get; set; }
        public float Field { get; set; }
        public float Arcade { get; set; }
        public float Trampoline { get; set; }
        public float ClimbingWall { get; set; }
        public float Birthday { get; set; }
        public string BirthdayComments { get; set; }
        public float FnB { get; set; }
        public float Store { get; set; }
        public float Academy { get; set; }
        public float SchoolTrips { get; set; }
        public float Others { get; set; }
        public float VRGames { get; set; }
        public float LaserGames { get; set; }
        public float Tournaments { get; set; }
        public float Bowling { get; set; }
        public DateTime LastUpdated { get; set; }
        public int WeekNum { get; set; }
        public float SoftPlay { get; set; }
        public float BigRides { get; set; }
        public float Cafe { get; set; }
    }
}