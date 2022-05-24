using ApiTest.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ApiTest.Services
{
    public class ToDoListRepository
    {
        public bool insertToDoList(ToDoList toDoList)
        {
            string connectionString = @"Data Source=DESKTOP-ITSFKII;Initial Catalog=SoftPlay;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = "insert into ToDoList (title, body, owner, insert_date, status) values ('" + 
                toDoList.Title + "','" + 
                toDoList.Body + "','" +
                toDoList.Owner + "','" +
                toDoList.insertDate + "','" +
                toDoList.Status + "')";

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