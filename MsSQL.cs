using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Bugtracker
{
    public class MsSQL
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=test_db;User Id = sa; Password = Yt,tcyfzcbybdf";
        public void MsSQLRequest(string sql_command)
        {


            using (SqlConnection sql_connection = new SqlConnection(connectionString))
            {
                sql_connection.Open();
                SqlCommand command = new SqlCommand(sql_command, sql_connection);
                command.ExecuteReader();
            }
        }
        public List<List<string>> MsSQLRequestResurnList(string sql_command)
        {
            using (SqlConnection sql_connection = new SqlConnection(connectionString))
            {
                sql_connection.Open();
                SqlCommand command = new SqlCommand(sql_command, sql_connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    List<List<string>> temp_list = new List<List<string>>();
                    while (reader.Read())
                    {
                        temp_list.Add(new List<string>());
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            //temp_list.Last().AddRange(reader.GetValues(0).ToString());
                            temp_list.Last().Add(reader.GetValue(i).ToString());
                        }                      
                        //temp += temp.Substring(0, temp.Length - 2) + "},";
                    }
                    return temp_list;
                }
                else
                    return null;

            }
        }
    } 
}