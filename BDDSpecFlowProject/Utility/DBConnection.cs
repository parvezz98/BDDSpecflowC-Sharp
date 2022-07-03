﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDSpecFlowProject.Utility
{
   public class DBConnection
    {
        public DataTable GetQueryResult(String vConnectionString, String vQuery)
        {
            SqlConnection Connection;  // It is for SQL connection
            DataSet ds = new DataSet();  // it is for store query result

            try
            {
                Connection = new SqlConnection(vConnectionString);  // Declare SQL connection with connection string 
                Connection.Open();  // Connect to Database
                Console.WriteLine("Connection with database is done.");

                SqlDataAdapter adp = new SqlDataAdapter(vQuery, Connection);  // Execute query on database 
                adp.Fill(ds);  // Store query result into DataSet object   
                Connection.Close();  // Close connection 
                Connection.Dispose();   // Dispose connection             
            }
            catch (Exception E)
            {
                Console.WriteLine("Error in getting result of query.");
                Console.WriteLine(E.Message);
                return new DataTable();
            }
            return ds.Tables[0];
        }
    }
}
