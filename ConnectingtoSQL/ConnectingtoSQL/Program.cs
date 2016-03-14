using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;

namespace ConnectingtoSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the connection
            SqlConnection conn = new SqlConnection("DataSource=(local);Initial Catalog=Northwind;Integrated Security=SSPI");

            SqlDataReader rdr = null;
            try
            {
                //open the connection
                conn.Open();
                //pass the connection to a command object
                SqlCommand cmd = new SqlCommand("SELECT PlayerName FROM PLAYER", conn);
                //user the connection
                //get query results
                rdr = cmd.ExecuteReader();

                //print information
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0]);
                }
            }
            finally
            {//close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }

            }


        }
    }
}
    

