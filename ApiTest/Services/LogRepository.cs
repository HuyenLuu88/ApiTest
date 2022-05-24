using ApiTest.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace ApiTest.Services
{
    public class LogRepository
    {
         public bool insertLog(Log log)
        {
            string connectionString = @"Data Source=DESKTOP-ITSFKII;Initial Catalog=SoftPlay;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();

            string sql = "insert into log (name, mobile, checkin, schedule, branch) values("
                + log.name + ","
                + log.mobile + ","
                + log.checkIn + ","
                + log.Schedule + ","
                + log.branch + ")";
            
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
            return true;
        }
    }
}