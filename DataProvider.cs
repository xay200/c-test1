using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    static internal class DataProvider
    {
        private static string link = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYSHOPQUANAO;Integrated Security=True;Trust Server Certificate=True";
        private static SqlConnection Connect()
        {
            return new SqlConnection(link);
        }


        public static DataTable GetDataTable(string sql)
        {
            try
            {
                SqlConnection conn = Connect();
                conn.Open();
                SqlDataAdapter dat = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                dat.Fill(dt);
                conn.Close();
                conn.Dispose();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public static void ExecuteNonQuery(string sql)
        {
            SqlConnection conn = Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public static string ExecuteScalar(string sql)
        {
            SqlConnection conn = Connect();
            conn.Open();
            SqlCommand cm = new SqlCommand(sql, conn);
            Object kq = cm.ExecuteScalar();
            conn.Close();
            conn.Dispose();
            if (kq != null)
            {
                return kq.ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
