using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SMS.Models;

namespace SMS.DAL
{
    public class Repository
    {
        static string _conString = @"Server=DESKTOP-6O78R2H; Database = StockManagement; Integrated Security = true";
        SqlConnection con = new SqlConnection(_conString);

        public bool CheckData(string query)
        {
           SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        } //Method for check Data to save as unique;


        public bool RunQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            
            con.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
                con.Close();
                throw new Exception("Database Execution error!");
        } //Method for insert data in Database;

        public DataTable GetAllItem(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            con.Close();
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            return dt;
        } // Method for Select All Item from database;

        public int GetValue(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            //int value = Convert.ToInt32(cmd.ExecuteReader()[0]);
            SqlDataReader rdr = cmd.ExecuteReader();
            int value = 0;
            while (rdr.Read())
            {
                value = rdr.GetInt32(0);
            }
            con.Close();
            return value;
        } //Method for get a single value from database;
    }
}
