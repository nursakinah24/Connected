﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Connected
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = GetConnectionString();
            string query1 = "select * from Pembimbing_Akademik where NIK=333";
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd1 = new SqlCommand(query1, cn); cn.Open();
                using (SqlDataReader dr1 = cmd1.ExecuteReader())
                {
                    while (dr1.Read())
                    {
                        string query2 = "UPDATE Pembimbing_Akademik SET Keahlian ='Jaringan' WHERE NIK = 333";
                        SqlCommand cmd2 = new SqlCommand(query2, cn);
                        cmd2.ExecuteNonQuery();
                        Console.WriteLine("Data has been updated");
                    }
                }
            }
            Console.ReadLine();
        }
        private static string GetConnectionString()
        {
            return "data source=LAPTOP-KINALAKA\\NURSAKINAH;database=ProdiTI; MultipleActiveResultSets=True; User Id=sa;Password=Palu24072002";
        }
    }
}
