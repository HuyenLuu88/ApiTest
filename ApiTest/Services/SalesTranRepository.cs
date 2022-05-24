using ApiTest.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ApiTest.Services
{
    public class SalesTranRepository
    {
        public List<SalesTranDTO> getList(SalesTranInput salesTranInput)
        {
            List<SalesTranDTO> list = new List<SalesTranDTO>();

            string connectionString = @"Data Source=DESKTOP-ITSFKII;Initial Catalog=SoftPlay;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();

            string sql = "select  ROUND(Sum(Total_Sales_amount),0) As TotalSales,"
                + " Round(sum(field) + sum(arcade) +sum(trampoline) +Sum(Soft_Play)+ sum(bowling) + SUM(big_rides)+Sum(Laser_Games)+Sum(Climbing_Wall),0) As GamesTotal, "
                + " Round(SUM(birthday) ,2) as birthday,"
                + " ROUND(Sum(cafe)+Sum(F_n_B),0) as FnB,"
                + " ROUND(Sum(store),0) as Store,"
                + " Round(Sum(Academy),0) As Academy,"
                + " Round(Sum(School_Trips),0) As Trips,"
                + " ROUND(Sum(Tournaments),0) As Tournaments,"
                + " ROUND(Sum(Others),0) As Others, sales_date from sales_tran where sales_date = '"
                + salesTranInput.dashDate
                + "' and branch = '"
                + salesTranInput.branch
                + "' group by Sales_Date order by TotalSales";


            SqlCommand sqlCommand = new SqlCommand(sql, cnn);

            using (SqlDataReader datareader = sqlCommand.ExecuteReader()) {
                if (datareader.HasRows)
                {
                    while (datareader.Read())
                    {
                        SalesTranDTO salesTranDTO = new SalesTranDTO();
                        salesTranDTO.totalSales = Convert.ToInt32(datareader.GetValue(0));
                        salesTranDTO.gamesTotal = Convert.ToInt32(datareader.GetValue(1));
                        salesTranDTO.birthday = (float)Convert.ToDouble(datareader.GetValue(2));
                        salesTranDTO.FnB = Convert.ToInt32(datareader.GetValue(3));
                        salesTranDTO.Store = Convert.ToInt32(datareader.GetValue(4));
                        salesTranDTO.Academy = Convert.ToInt32(datareader.GetValue(5));
                        salesTranDTO.Trips = Convert.ToInt32(datareader.GetValue(6));
                        salesTranDTO.Tournaments = Convert.ToInt32(datareader.GetValue(7));
                        salesTranDTO.Others = Convert.ToInt32(datareader.GetValue(8));
                        salesTranDTO.SalesDate = Convert.ToDateTime(datareader.GetDateTime(9));

                        list.Add(salesTranDTO);
                    }
                }
            }

                
            sqlCommand.Dispose();
            cnn.Close();
            return list;
        }
    }
}